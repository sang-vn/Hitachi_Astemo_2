using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_Astemo.Models
{
    public partial class Test : Form
    {
        FileTXT fileTXT = null;
        public string maSp;
        public Test()
        {
            InitializeComponent();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            fileTXT = new FileTXT();
            bool kt = fileTXT.WriteFile(double.Parse(tbIndex.Text), tbMaSp.Text);
            if (kt) MessageBox.Show("Luu thanh cong");
            else MessageBox.Show("Luu that bai");
            fileTXT.Dispose();
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            fileTXT = new FileTXT();
            fileTXT.ReadFile(double.Parse(tbIndex.Text) , out maSp);
            tbMaSp.Text = maSp;
            fileTXT.Dispose();
        }
    }
}
