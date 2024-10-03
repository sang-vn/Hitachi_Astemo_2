using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using CSharp_OPTControllerAPI;
using static OpenCvSharp.ConnectedComponents;

namespace Hitachi_Astemo
{
    public partial class Setup_Lights : Form
    {
        OPTControllerAPI light = null;
        private Main mainForm = null;

        public Setup_Lights(Main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void Setup_Lights_Load(object sender, EventArgs e)
        {
            if (mainForm.Light == null) mainForm.Light = new OPTControllerAPI();
            mainForm.Light.CreateEthernetConnectionByIP("192.168.1.16");

            bnConnect.Text = "Disconnect";
            lbNotice.Text = "Connected";
            lbNotice.BackColor = Color.Green;
            
        }

        private void bnConnect_Click(object sender, EventArgs e)
        {
            if(bnConnect.Text == "Connect")
            {
                long lRet = -1;

                try 
                {
                    lRet = mainForm.Light.CreateEthernetConnectionByIP("192.168.1.16");
                    if (0 != lRet)
                    {
                        bnConnect.Text = "Connect";
                        lbNotice.Text = "Disconnected";
                        lbNotice.BackColor = Color.Red;
                        MessageBox.Show("Can not connect Lights");
                        return;
                    }
                    else
                    {
                        bnConnect.Text = "Disconnect";
                        lbNotice.Text = "Connected";
                        lbNotice.BackColor = Color.Green;
                        MessageBox.Show("Connected Lights");
                        light.SetIntensity(1, trackBar1.Value);
                        light.SetIntensity(2, trackBar2.Value);
                        light.SetIntensity(3, trackBar3.Value);
                        light.SetIntensity(4, trackBar4.Value);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(bnConnect.Text == "Disconnect")
            {
                lbNotice.Text = "Disconnected";
                lbNotice.BackColor = Color.Red;
                mainForm.Light.DestroyEthernetConnect();
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mainForm.Light.SetIntensity(1, trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            mainForm.Light.SetIntensity(2, trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            mainForm.Light.SetIntensity(3, trackBar3.Value);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            mainForm.Light.SetIntensity(4, trackBar4.Value);
        }

        private void Setup_Lights_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Light.DestroyEthernetConnect();
        }
    }
}
