using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Cognex.Vision;
using Cognex.VisionPro.ToolBlock;
using System.IO;
using Cognex.VisionPro;
//using Cognex.VisionPro.ToolBlock;
using System.Security.Cryptography;
using System.Net.Sockets;
using CSharp_OPTControllerAPI;
using System.Windows.Media.Media3D;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.Timers;
using HslCommunication;
using HslCommunication.Profinet;
using Cognex.VisionPro.ImageFile;
using System.Windows.Forms.VisualStyles;
using Hitachi_Astemo.Models;

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {

        //Tool Block
        private CogToolBlock tbVisionTool = null;
        private CogAcqFifoTool tbGetImageTool = null;
        //private CogImageFileTool tbGetImageTool = null;
        private CogToolBlock tbImageProcessingTool = null;

        //Intial connect PLC 
        public HslCommunication.Profinet.Melsec.MelsecA1ENet PLC = null;
        private int Port_PLC = 3000;

        //Intial connect Lights
        public OPTControllerAPI Light = null;
        private TcpClient tcpClient_Lights = new TcpClient();
        private string IpAddress_Lights = "192.168.1.16";
        //public int Port_Lights = 3000;
        private int intensity1 = 200;
        private int intensity2 = 200;
        private int intensity3 = 200;
        private int intensity4 = 200;

        private int run_flag = 0;
        private bool trigger = false;
        private int model = 1;
        public string FileName = "HMLLOR";

        private System.Timers.Timer timerTrigger = new System.Timers.Timer();
        private System.Timers.Timer timerHeartBit = new System.Timers.Timer();

        private int NG_Counter = 0;
        private int OK_Counter = 0;
        private List<ICogRecord> NG_Images = new List<ICogRecord>();
        private List<CogRecordDisplay> NG_Display = new List<CogRecordDisplay>(); 

        DateTime dateTime = new DateTime();



        public Main()
        {
            InitializeComponent();

            //Loop read trigger from PLC then run Job
            if (timerTrigger == null) timerTrigger = new System.Timers.Timer();
            timerTrigger.Enabled = false;
            timerTrigger.Interval = 100;
            timerTrigger.AutoReset = true;
            timerTrigger.Elapsed += TimerTrigger_Elapsed;

            //Loop send HeartBit
            if (timerHeartBit == null) timerHeartBit = new System.Timers.Timer();
            timerHeartBit.Enabled = false;
            timerHeartBit.Interval = 100;
            timerHeartBit.AutoReset = true;
            timerHeartBit.Elapsed += TimerHearBit_Elapsed;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tsChuongTrinh_Menu1.Enabled = false;
            tsSetupCamera_Menu1.Enabled = false;
            tsSetupPLC_Menu1.Enabled = false;
            tsSetupLights_Menu1.Enabled = false;
            tsLogs_Menu1.Enabled = true;
            tsHelps_Menu1.Enabled = true;

            lbNgCounter.Text = NG_Counter.ToString();
            lbOkCounter.Text = OK_Counter.ToString();

            tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Open Program\r\n");

            NG_Display.Add(cogRecordDisplay2);
            NG_Display.Add(cogRecordDisplay3);
            NG_Display.Add(cogRecordDisplay4);
            NG_Display.Add(cogRecordDisplay5);

            IntialPLC();
            IntialLights();
            IntialProgram();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dispose Timer
            timerHeartBit.Stop();
            timerHeartBit.Dispose();
            timerTrigger.Stop();
            timerTrigger.Dispose();

            //Disconnect Lights
            //long lRet = -1;
            //lRet = Light.DestroyEthernetConnect();
            //if (lRet != 0) MessageBox.Show("Failed to disconnect Lights");
            //else MessageBox.Show("Disconnected Lights");

            //Disconnect PLC
            PLC.ConnectClose();
            PLC.Dispose();


        }

        //Timer Heart Bit
        private void TimerHearBit_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (run_flag == 0)
            {
                timerHeartBit.Stop();
                timerHeartBit.Enabled = false;
            }
            else
            {
                Invoke(new Action(() =>
                {
                    PLC.Write("M2040", (bool)true);
                }));
            }
                
        }

        //Timer Trigger
        private void TimerTrigger_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    int check_model = PLC.ReadInt16("D1000").Content;
                    Invoke(new Action(() =>
                    {
                        //Kiểm tra model. Nếu có thay đổi thì Load lại chương trình xử lý ảnh, reset lại các biến đếm OK/NG
                        if (model != check_model || tbVisionTool == null)
                        {
                            NG_Counter = 0;
                            OK_Counter = 0;

                            model = check_model;
                            FileTXT fileTXT = new FileTXT();
                            fileTXT.ReadFile(model, out FileName);
                            fileTXT.Dispose();

                            lbModel.Text = FileName;

                            string VisionToolPath = AppDomain.CurrentDomain.BaseDirectory + "VPro_Program\\" + FileName + ".vpp";
                            tbVisionTool = new CogToolBlock();
                            tbVisionTool = CogSerializer.LoadObjectFromFile(VisionToolPath) as CogToolBlock;

                            tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Change Program to {FileName}\r\n");
                        }
                    }));

                    //Gán lại các tool trong Tool trong ToolBlock
                    tbGetImageTool = tbVisionTool.Tools["CogAcqFifoTool1"] as CogAcqFifoTool;
                    tbImageProcessingTool = tbVisionTool.Tools["CogToolBlock1"] as CogToolBlock;

                    //Gán giá trị các biến đếm
                    NG_Counter = PLC.ReadInt16("D1100").Content;
                    OK_Counter = PLC.ReadInt16("D1102").Content;
                    lbNgCounter.Text = NG_Counter.ToString();
                    lbOkCounter.Text = OK_Counter.ToString();

                    //Gán các giá trị độ sáng đèn
                    intensity1 = (int)tbVisionTool.Inputs["Intensity1"].Value;
                    intensity2 = (int)tbVisionTool.Inputs["Intensity2"].Value;
                    intensity3 = (int)tbVisionTool.Inputs["Intensity3"].Value;
                    intensity4 = (int)tbVisionTool.Inputs["Intensity4"].Value;

                    //Kiểm tra tín hiệu trigger
                    trigger = PLC.ReadBool("M2001").Content;
                    if (trigger)
                    {
                        Light.SetIntensity(1, intensity1);
                        Light.SetIntensity(2, intensity2);
                        Light.SetIntensity(3, intensity3);
                        Light.SetIntensity(4, intensity4);
                        Thread.Sleep(30);

                        tbGetImageTool.Run();
                        //if (tbGetImageTool.FailOnInvalidDataBinding) PLC.Write("M2011", (bool)true);
                        PLC.Write("M2010", (bool)true);

                        Thread.Sleep(0);

                        Light.SetIntensity(1, 10);
                        Light.SetIntensity(2, 10);
                        Light.SetIntensity(3, 10);
                        Light.SetIntensity(4, 10);

                        tbImageProcessingTool.Inputs["InputImage"].Value = tbGetImageTool.OutputImage;
                        tbImageProcessingTool.Run();

                        Display(cogRecordDisplay1, tbImageProcessingTool);
                        int position = (int)tbImageProcessingTool.Outputs["Position"].Value;
                        int result = 0;

                        //Nếu là mặt 1
                        if (position == 1)
                        {
                            result = (int)tbImageProcessingTool.Outputs["Pos1_Scored"].Value;
                            if (result == 1)
                            {
                                PLC.Write("M2020", (bool)true);
                                tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm:ss")}: Pos 1 OK -> ");
                            }
                            else
                            {
                                NG_Images.Insert(0, tbImageProcessingTool.CreateLastRunRecord().SubRecords[2]);
                                if (NG_Images.Count > 4) NG_Images.RemoveAt(4);
                                PLC.Write("M2030", (bool)true);
                                tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm:ss")}: Pos 1 NG -> ");
                            }
                        }

                        //Nếu là mặt 2
                        if (position == 2)
                        {
                            result = (int)tbImageProcessingTool.Outputs["Pos2_Scored"].Value;
                            if (result == 1)
                            {
                                PLC.Write("M2021", (bool)true);
                                tbLog.AppendText($"Pos 2 OK -> ");
                            }
                            else
                            {
                                NG_Images.Insert(0, tbImageProcessingTool.CreateLastRunRecord().SubRecords[2]);
                                if (NG_Images.Count > 4) NG_Images.RemoveAt(4);
                                PLC.Write("M2031", (bool)true);
                                tbLog.AppendText($"Pos 2 NG -> ");
                            }
                        }

                        //Nếu là mặt 3
                        if (position == 3)
                        {
                            result = (int)tbImageProcessingTool.Outputs["Pos3_Scored"].Value;
                            if (result == 1)
                            {
                                PLC.Write("M2022", (bool)true);
                                tbLog.AppendText($"Pos 3 OK\r\n");
                            }
                            else
                            {
                                NG_Images.Insert(0, tbImageProcessingTool.CreateLastRunRecord().SubRecords[2]);
                                if (NG_Images.Count > 4) NG_Images.RemoveAt(4);
                                PLC.Write("M2032", (bool)true);
                                tbLog.AppendText($"Pos 3 NG\r\n");
                            }
                        }

                        for (int i = 0; i < NG_Images.Count; i++)
                        {
                            NG_Display[i].Record = NG_Images[i];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }));
            
        }

        void Display(CogRecordDisplay dsp, CogToolBlock tb)
        {
            dsp.InteractiveGraphics.Clear();
            dsp.StaticGraphics.Clear();
            dsp.Record = tb.CreateLastRunRecord().SubRecords[1];

        }

        #region Event Click Button
        private void bnBegin_Click(object sender, System.EventArgs e)
        {
            timerTrigger.Enabled = true;
            timerTrigger.Start();

            timerHeartBit.Enabled = true;
            timerHeartBit.Start();

            tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm:ss")}: __BEGIN__\r\n");
        }

        private void bnEnd_Click(object sender, EventArgs e)
        {
            timerTrigger.Stop();
            timerTrigger.Enabled = false;

            timerHeartBit.Stop();
            timerHeartBit.Enabled = false;
            tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm:ss")}: __END__\r\n");
        }

        //Setup Camera
        private void tsSetupCamera_Menu1_Click(object sender, System.EventArgs e)
        {
            string path_1 = AppDomain.CurrentDomain.BaseDirectory + "VPro_Program\\SetupCamera.vpp";
            ToolEdit setup_Camera = new ToolEdit(path_1);
            setup_Camera.Text = "Setup Camera";
            setup_Camera.ShowDialog();
        }


        //Setup PLC
        private void tsSetupPLC_Menu1_Click(object sender, System.EventArgs e)
        {
            Connect_PLC connect_PLC = new Connect_PLC(this);
            connect_PLC.tbIpAddress.Text = "192.168.1.100";
            connect_PLC.tbPort.Text = "3000";
            connect_PLC.IPChanged += PLC_IP_Changed;
            connect_PLC.ShowDialog();
        }

        //Setup Lights
        private void tsSetupLights_Menu1_Click(object sender, EventArgs e)
        {
            Setup_Lights setup_Lights = new Setup_Lights(this);
            setup_Lights.Show();
        }

        private void PLC_IP_Changed(object sender, Tuple<string, int> inIP)
        {
            //this.IpAddress_PLC = inIP.Item1;
            //this.Port_PLC = inIP.Item2;


            //this.bnBegin.Text = Convert.ToString(IpAddress_PLC);
            //this.bnEnd.Text = Convert.ToString(Port_PLC);

            //if(tcpClient_PLC != null) tcpClient_PLC.Dispose();
            //IntialPLC();
        }

        #endregion

        #region Intialize

        //Intial Program
        private void IntialProgram()
        {
            try
            {
                string VisionToolPath = AppDomain.CurrentDomain.BaseDirectory + "VPro_Program\\HMLLOR.vpp";
                tbVisionTool = new CogToolBlock();
                tbVisionTool = CogSerializer.LoadObjectFromFile(VisionToolPath) as CogToolBlock;

                tbGetImageTool = tbVisionTool.Tools["CogAcqFifoTool1"] as CogAcqFifoTool;
                tbImageProcessingTool = tbVisionTool.Tools["CogToolBlock1"] as CogToolBlock;

                tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Loaded Program HMLLOR\r\n");

                lbModel.Text = "HMLLOR";
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Load VPP Fail!");
            }
        }

        //Intial PLC
        private void IntialPLC()
        {
            try
            {
                if (PLC == null)
                    PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100",3000);
                OperateResult connect = PLC.ConnectServer();
                if (connect.IsSuccess)
                {
                    lbPLCConnected.Text = "Connected";
                    lbPLCConnected.ForeColor = Color.Lime;
                    tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Connected PLC\r\n");
                    //MessageBox.Show("Connected PLC");
                }
                else
                {
                    lbPLCConnected.Text = "Disconnected";
                    lbPLCConnected.ForeColor = Color.Red;
                    tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Can not connect PLC\r\n");
                    MessageBox.Show("Can not connected PLC");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        //Intial Lights
        private void IntialLights()
        {
            long lRet = -1;
            Light = new OPTControllerAPI();
            try
            {
                lRet = Light.CreateEthernetConnectionByIP(IpAddress_Lights);
                if (0 != lRet)
                {
                    lbLightsConnected.Text = "Disconnected";
                    lbLightsConnected.ForeColor = Color.Red;
                    tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Can not connect Lights\r\n");
                    MessageBox.Show("Cannot connect Lights");
                    return;
                }
                else
                {
                    lbLightsConnected.Text = "Connected";
                    lbLightsConnected.ForeColor = Color.Lime;
                    tbLog.AppendText($"{DateTime.Now.ToString("dd-MM-yy HH:mm")}: Connected Lights\r\n");
                    //MessageBox.Show("Connected Lights");
                    Light.SetIntensity(1, 10);
                    Light.SetIntensity(2, 10);
                    Light.SetIntensity(3, 10);
                    Light.SetIntensity(4, 10);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void tsEdit__Menu2_Click(object sender, EventArgs e)
        {

        }

        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbUser.SelectedIndex)
            {
                case 0:
                    Login login1 = new Login("admin");
                    login1.IPChanged += Login_Admin;
                    login1.Show();
                    break;
                case 1:
                    Login login2 = new Login("programmer");
                    login2.IPChanged += Login_Programmer;
                    login2.Show();
                    break;
                case 2:
                    tsChuongTrinh_Menu1.Enabled = false;
                    tsSetupCamera_Menu1.Enabled = false;
                    tsSetupPLC_Menu1.Enabled = false;
                    tsSetupLights_Menu1.Enabled = false;
                    tsLogs_Menu1.Enabled = true;
                    tsHelps_Menu1.Enabled = true;
                    break;
                default:
                    break;
             }
        }

        private void Login_Admin(object sender, EventArgs e)
        {
            tsChuongTrinh_Menu1.Enabled = true;
            tsSetupCamera_Menu1.Enabled = true;
            tsSetupPLC_Menu1.Enabled = true;
            tsSetupLights_Menu1.Enabled = true;
            tsLogs_Menu1.Enabled = true;
            tsHelps_Menu1.Enabled = true;
        }

        private void Login_Programmer(object sender, EventArgs e)
        {
            tsChuongTrinh_Menu1.Enabled = false;
            tsSetupCamera_Menu1.Enabled = true;
            tsSetupPLC_Menu1.Enabled = true;
            tsSetupLights_Menu1.Enabled = true;
            tsLogs_Menu1.Enabled = true;
            tsHelps_Menu1.Enabled = true;
        }

        private void tsChuongTrinh_Menu1_Click(object sender, EventArgs e)
        {
            EditProgram programs = new EditProgram();
            programs.Show();
        }
    }
}
