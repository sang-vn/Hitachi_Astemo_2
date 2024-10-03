using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_Astemo
{
    public partial class EditProgram : Form
    {
        public string[] lstModel = null;
        public string GetChangeProduct = null;
        public CogToolBlock cogtoolblock = null;
        public string pathToolBlock;

        public EditProgram()
        {
            InitializeComponent();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            int currentLineIndex = tbListPrograms.GetLineFromCharIndex(tbListPrograms.SelectionStart);
            string selectedLine = tbListPrograms.Lines[currentLineIndex];

            pathToolBlock = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VPro_Program", selectedLine);
            MessageBox.Show(pathToolBlock);

            ToolEdit toolEdit = new ToolEdit(this.pathToolBlock);
            toolEdit.ShowDialog();
        }

        private void Programs_Load(object sender, EventArgs e)
        {
            lstModel = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "VPro_Program", "*.vpp");
            foreach (string file in lstModel)
            {
                tbListPrograms.AppendText(Path.GetFileName(file)+"\r\n");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == null)
            {
                foreach (string file in lstModel)
                {
                    tbListPrograms.AppendText(Path.GetFileName(file) + "\r\n");
                }
            }
            else
            {
                string seachQuery = tbSearch.Text.ToLower();
                tbListPrograms.Clear();
                foreach (string file in lstModel)
                {
                    if (Path.GetFileName(file).ToLower().Contains(seachQuery))
                    {
                        tbListPrograms.AppendText(Path.GetFileName(file) + "\r\n");
                    }
                }
            }
        }
    }
}

