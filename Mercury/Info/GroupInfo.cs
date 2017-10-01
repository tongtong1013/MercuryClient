using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Info
{
    public class GroupInfo : WebClient
    {
        public string ID;
        public int GroupID;
        public string GroupName;

        public Dictionary<int, string> Search()
        {
            string url = "http://localhost/groupInfo.php?id=" + ID;//int型键值转为json字符串时会变成string型，再反序列化回来又会变成int型
            string response = this.HttpGet(url);
            Dictionary<int, string> infos = Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(Dictionary<int, string>)) as Dictionary<int, string>;
            return infos;
        }
    }
}
