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
    public partial class FriendCtrl : UserControl
    {
        private PersonInfo _personInfo;
        public FriendCtrl(PersonInfo personInfo)
        {
            InitializeComponent();
            _personInfo = personInfo;
        }
    }
}
