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
        public MainForm()
        {
            InitializeComponent();
            this.pbFriendPhoto.Image = _tempFriend;
            this.Icon = _star;
        }

        private void plFriend_DoubleClick(object sender, EventArgs e)
        {
            ChatForm cf = new ChatForm();
            cf.Show();
        }
    }
}
