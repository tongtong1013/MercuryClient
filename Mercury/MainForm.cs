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
    public partial class MainForm : Form
    {
        private Bitmap _tempFriend = Properties.Resources.tx1;
        private Icon _star = Properties.Resources.star;
        private string _id;
        public MainForm(string id)
        {
            InitializeComponent();
            this.Icon = _star;
            _id = id;
            GetOwnerInfo();
        }

        private void GetOwnerInfo()
        {
            PersonInfo pi = new PersonInfo();
            pi.ID = _id;
            pi = pi.Search();
            this.lbName.Text = pi.Name;
            this.lbSign.Text = pi.Sign == "" ? "这个人很懒，神马都没有留下～" : pi.Sign;
        }

        private void GetFriendsInfo()
        {

        }

        private void lbAddFriends_Click(object sender, EventArgs e)
        {

        }
    }
}
