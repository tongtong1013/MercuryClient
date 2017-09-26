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
using System.IO;
using System.Threading;

namespace Mercury
{
    public partial class LoginForm : Form
    {
        private Icon _star = Properties.Resources.star;
        public LoginForm()
        {
            InitializeComponent();
            this.Icon = _star;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lbNote.Visible = false;
            this.epError.Clear();
            if(this.tbID.Text.Trim() == "")
            {
                this.epError.SetError(this.tbID, "ID不能为空！");
                return;
            }
            if (this.tbPassword.Text.Trim() == "")
            {
                this.epError.SetError(this.tbPassword, "密码不能为空！");
                return;
            }

            LoginService ls = new LoginService();
            ls.id = this.tbID.Text;
            ls.password = this.tbPassword.Text;
            bool result = ls.Search();
            if (result)
            {
                this.Close();
                new Thread(() => Application.Run(new MainForm(ls.id))).Start();
            }
            else
            {
                this.lbNote.Visible = true;
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
            rf.Dispose();
            rf = null;
        }
    }
}
