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
    public class ServerInfo
    {
        public string username;
        public string password;
    }

    public class Repmsg
    {
        public int answer;
    }

    public partial class Form1 : Form
    {
        private string _url = "http://localhost/";
        private Icon _star = Properties.Resources.star;
        public Form1()
        {
            InitializeComponent();
            this.Icon = _star;
        }

        private bool LoginServer(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            request.Method = "POST";
            //request.ContentType = "application/json;charset=utf-8";
            request.ContentType = "application/x-www-form-urlencoded";

            string id = this.tbID.Text;
            string password = this.tbPassword.Text;
            string str = "username=" + id + "&password=" + password;
            Console.WriteLine(str);
            byte[] postdatabyte = Encoding.UTF8.GetBytes(str);
            request.ContentLength = postdatabyte.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postdatabyte, 0, postdatabyte.Length);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string strResponse = streamReader.ReadToEnd();
            Console.WriteLine(strResponse);


            Repmsg repmsg = Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse,typeof(Repmsg)) as Repmsg;
            //if (strResponse.Contains("yes"))
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}
            bool result;
            if (repmsg.answer == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            requestStream.Dispose();
            response.Dispose();
            responseStream.Dispose();
            streamReader.Dispose();

            return result;
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
            bool result = LoginServer(_url);
            if (result)
            {
                this.Close();
                new Thread(() => Application.Run(new MainForm())).Start();
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
    }
}
