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
    public partial class ChatForm : Form
    {
        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }
        }
        private PersonInfo _personInfo;
        public ChatForm(string id, PersonInfo personInfo)
        {
            InitializeComponent();
            _id = id;
            _personInfo = personInfo;
            this.Text = "与 " + _personInfo.Name +" 对话中...";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SocketClient sc = new SocketClient("127.0.0.1");
        }

        private void rtbSend_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
