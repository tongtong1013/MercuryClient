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
        private ChatForm _cf;

        private static string _id = "";
        public string ID
        {
            get
            {
                return _id;
            }
        }
        

        public ChatForm(string id)
        {
            //_id = id;
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item is ChatForm)
            //    {
            //        if ((item as ChatForm).ID == id)
            //        {
            //        }
            //    }
            //}
            //if (null == _cf)
            //{
            //    _cf = new ChatForm();
            //}
            InitializeComponent();
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
