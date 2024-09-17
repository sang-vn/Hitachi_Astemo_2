using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using OpenCvSharp;
using System.IO;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

using HslCommunication;
using HslCommunication.Profinet;

namespace Hitachi_Astemo
{
    public partial class Connect_PLC : Form
    {
        //Intial connect PLC 
        private HslCommunication.Profinet.Melsec.MelsecA1ENet PLC = null;
        private string IpAddress = "192.168.1.100";
        private int Port = 3000;

        private Main mainForm;
        
        
        public Connect_PLC(Main main)
        {
            InitializeComponent();
            mainForm = main;
            this.Load += new EventHandler(Connect_PLC_Load);
        }

        private void bnConnect_Click(object sender, EventArgs e)
        {
            if (bnConnect.Text == "Connect")
            {

                if (mainForm.PLC == null)
                    mainForm.PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100", 3000);
                try 
                {
                    OperateResult connect = mainForm.PLC.ConnectServer();
                    if (connect.IsSuccess)
                    {
                        bnConnect.Text = "Disconnect";
                        lbNotice.Text = "Connected";
                        lbNotice.BackColor = Color.Green;
                        tbSentData.Text = "<--- Choose this before send data";
                        cbInvert.Enabled = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bnConnect.Text == "Disconnect")
            {
                try
                {
                    mainForm.PLC.ConnectClose();
                    bnConnect.Text = "Connect";
                    lbNotice.Text = "Disconnected";
                    lbNotice.BackColor = Color.Red;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void Connect_PLC_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                mainForm.PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100", 3000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Connect_PLC_Load(object sender, EventArgs e)
        {
            if(mainForm.PLC == null) mainForm.PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100", 3000);

            if (mainForm.PLC.ConnectServer().IsSuccess)
            {
                bnConnect.Text = "Disconnect";
                lbNotice.Text = "Connected";
                lbNotice.BackColor = Color.Green;
            }
            else
            {
                mainForm.PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100", 3000);
                bnConnect.Text = "Disconnect";
                lbNotice.Text = "Connected";
                lbNotice.BackColor = Color.Green;
            }
        }


        public event EventHandler<Tuple<string, int>> IPChanged;

        //private void tbIpAddress_TextChanged(object sender, EventArgs e)
        //{
        //    IPChanged?.Invoke(this, new Tuple<string, int>(tbIpAddress.Text,int.Parse(tbPort.Text)));
        //}

        private void bnSave_Click(object sender, EventArgs e)
        {
            IPChanged?.Invoke(this, new Tuple<string, int>(tbIpAddress.Text, int.Parse(tbPort.Text)));
        }

        private void bnReadTrigger_Click(object sender, EventArgs e)
        {
            tbReceivedData.Text = (mainForm.PLC.ReadBool("M2001").Content).ToString();
        }

        private void bnWriteAcqOK_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2010", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2010", (bool)true);
            }
        }

        private void bnWriteAcqNG_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2011", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2011", (bool)true);
            }
        }

        private void bnWriteResultOK_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2020", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2020", (bool)true);
            }
        }

        private void bnWriteResultNG1_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2030", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2030", (bool)true);
            }
        }

        private void bnWriteResultNG2_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2031", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2031", (bool)true);
            }
        }

        private void bnWriteResultNG3_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2032", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2032", (bool)true);
            }
        }

        private void bnHeartBits_Click(object sender, EventArgs e)
        {
            if (cbInvert.Checked)
            {
                mainForm.PLC.Write("M2040", (bool)false);
            }
            else
            {
                mainForm.PLC.Write("M2040", (bool)true);
            }
        }

        private void bnReadModel_Click(object sender, EventArgs e)
        {
            tbReceivedData.Text = (mainForm.PLC.ReadInt16("D1000").Content).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbReceivedData.Text = (mainForm.PLC.ReadInt16("D1100").Content).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbReceivedData.Text = (mainForm.PLC.ReadInt16("D1102").Content).ToString();
        }
    }
}
