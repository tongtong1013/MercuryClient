using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercury.Info;

namespace Mercury
{
    public partial class MainForm : Form
    {
        private Bitmap _tempFriend = Properties.Resources.tx1;
        private Icon _star = Properties.Resources.star;
        private string _id;
        private Dictionary<string, int> _relationship;
        private Dictionary<int, string> _groupInfo;
        public MainForm(string id)
        {
            InitializeComponent();
            this.Icon = _star;
            _id = id;
            GetOwnerInfo();
            GetGroupInfo();
            GetRelationship();
        }

        private void GetOwnerInfo()
        {
            PersonInfo pi = new PersonInfo();
            pi.ID = _id;
            pi = pi.Search();
            this.lbName.Text = pi.Name;
            this.lbSign.Text = pi.Sign == "" ? "这个人很懒，神马都没有留下～" : pi.Sign;
        }
        private void GetGroupInfo()
        {
            GroupInfo gi = new GroupInfo();
            gi.ID = _id;
            _groupInfo = gi.Search();
            foreach (KeyValuePair<int, string> item in _groupInfo)
            {
                TreeNode tn = new TreeNode();
                tn.Tag = item;
                tn.Text = item.Value;
                tn.Name = item.Value;
                this.tvFriends.Nodes.Add(tn);
                //this.tvFriends.Nodes.Add(item.Key + "", item.Value);//这个很好用，但是有问题，如果value重复呢？
            }
        }
        private void GetRelationship()
        {
            Relationship r = new Relationship();
            r.OwnerID = _id;
            _relationship = r.Search();

            foreach (KeyValuePair<string, int> item in _relationship)
            {
                foreach (TreeNode tnRoot in this.tvFriends.Nodes)
                {
                    if (((KeyValuePair<int, string>)tnRoot.Tag).Key == item.Value)
                    {
                        PersonInfo pi = new PersonInfo();
                        pi.ID = item.Key;
                        pi = pi.Search();
                        TreeNode tnChild = new TreeNode();
                        tnChild.Tag = pi;
                        tnChild.Text = pi.Name;
                        tnRoot.Nodes.Add(tnChild);
                        break;
                    }
                }
            }
        }

        private void lbAddFriends_Click(object sender, EventArgs e)
        {

        }

        private void tvFriends_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (null == e.Node.Parent)
            {
                return;
            }
            TreeNode tnChild = e.Node;
            bool _hasOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (!(item is ChatForm))
                {
                    continue;
                }
                ChatForm cf = item as ChatForm;
                if (cf.ID == (e.Node.Tag as PersonInfo).ID)
                {
                    _hasOpen = true;
                    cf.Show();
                    cf.Activate();
                    break;
                }
            }
            if (!_hasOpen)
            {
                ChatForm cf = new ChatForm((e.Node.Tag as PersonInfo).ID, e.Node.Tag as PersonInfo);
                cf.Show();
            }
        }
    }
}
