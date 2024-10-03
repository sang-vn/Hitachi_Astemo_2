using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
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
    public partial class ToolEdit : Form
    {
        private string path_2;

        public ToolEdit(string path_1)
        {
            InitializeComponent();
            path_2 = path_1;
            try
            {
                CogToolBlock toolBlock1 = new CogToolBlock();
                toolBlock1 = CogSerializer.LoadObjectFromFile(path_2) as CogToolBlock;
                //cogToolBlockEdit.Subject = toolBlock1;
                path_2 = cogToolBlockEdit.Subject.Name;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Load ToolBlock Fail!");}
        }

        private void cogToolBlockEdit_SubjectChanged(object sender, EventArgs e)
        {
            MessageBox.Show(path_2);
            path_2 = cogToolBlockEdit.Subject.Name;
        }
    }
}
