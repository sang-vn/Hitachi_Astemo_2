using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_Astemo
{
    public partial class Login : Form
    {
        string scope = "";
        private string username;
        private string password;
        public Login(string text)
        {
            InitializeComponent();
            scope = text;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(scope == "admin")
            {
                username = "admin";
                password = "123456";
            }
            if (scope == "programmer")
            {
                username = "programmer";
                password = "123456";
            }    
        }

        public event EventHandler IPChanged;

        private void bnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == username && tbPassword.Text == password)
            {
                IPChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        
    }
}
