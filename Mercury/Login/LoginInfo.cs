using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    public class Repmsg
    {
        public int answer;
    }

    public class LoginService : WebClient
    {
        public string id;
        public string password;
        public bool Search()
        {
            string method = "POST";
            string url = "http://localhost/loginService.php";
            string data = "id=" + id + "&password=" + password;
            string response = this.HttpPost(method, url, data);
            Repmsg repmsg = Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(Repmsg)) as Repmsg;
            bool result;
            if (repmsg.answer == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool Add()
        {
            string method = "POST";
            string url = "http://localhost/registerService.php";
            string data = "id=" + id + "&password=" + password;
            string response = this.HttpPost(method, url, data);
            Repmsg repmsg = Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(Repmsg)) as Repmsg;
            bool result;
            if (repmsg.answer == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
