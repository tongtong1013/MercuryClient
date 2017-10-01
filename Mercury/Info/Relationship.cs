using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Info
{
    public class Relationship : WebClient
    {
        public string OwnerID;
        public string FirendID;
        public int Group;

        public Dictionary<string, int> Search()
        {
            string url = "http://localhost/relationship.php?ownerID=" + OwnerID;
            string response = this.HttpGet(url);
            Dictionary<string, int> infos = Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(Dictionary<string, int>)) as Dictionary<string, int>;
            return infos;
        }
    }
}
