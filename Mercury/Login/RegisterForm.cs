using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercury
{
    public partial class RegisterForm : Form
    {
        private Icon _icon = Properties.Resources.star;
        public RegisterForm()
        {
            InitializeComponent();
            this.Icon = _icon;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.epError.Clear();
            if(this.tbID.Text == "")
            {
                this.epError.SetError(this.tbID, "账号不能为空！");
                return;
            }
            if(this.tbPassword.Text == "")
            {
                this.epError.SetError(this.tbPassword, "密码不能为空！");
                return;
            }
            if(this.tbPasswordAgain.Text != this.tbPassword.Text)
            {
                this.epError.SetError(this.tbPasswordAgain, "两次密码不一致！");
                return;
            }
            LoginService ls = new LoginService();
            ls.id = this.tbID.Text;
            ls.password = this.tbPassword.Text;
            bool result = ls.Add();
            if(!result)
            {
                MessageBox.Show("该账号已存在！");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
