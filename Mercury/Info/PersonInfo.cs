using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mercury
{
    public class PersonInfo : WebClient
    {
        //账号
        public string ID;
        //昵称
        public string Name;
        //性别：女0，男1
        public bool Sexual;
        //出生年月
        public string Birthday;
        //血型
        public string BloodType;
        //职业
        public string Vocation;
        //家乡
        public string Hometown;
        //所在地
        public string Location;
        //学校
        public string School;
        //公司
        public string Company;
        //手机
        public string PhoneTel;
        //邮箱
        public string Mail;
        //签名
        public string Sign;
        //说明
        public string Detail;
        //头像
        public string Photo;

        public PersonInfo Search()
        {
            //string method = "POST";
            //string url = "http://localhost/personInfo.php?id=" + ID;
            //string response = this.HttpPost(method, url, "");
            //string method = "GET";
            string url = "http://localhost/personInfo.php?id=" + ID;
            //string data = "id=" + id + "&password=" + password;
            //string data = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            string response = this.HttpGet(url);
            PersonInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(PersonInfo)) as PersonInfo;

            return info;
        }
    }
}
