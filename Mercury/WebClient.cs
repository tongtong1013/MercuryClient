using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Mercury
{
    public class WebClient
    {
        protected string HttpPost(string method,string url,string data)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            request.Method = method;
            //request.ContentType = "application/json;charset=utf-8";
            request.ContentType = "application/x-www-form-urlencoded";

            byte[] postdatabyte = Encoding.UTF8.GetBytes(data);
            request.ContentLength = postdatabyte.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postdatabyte, 0, postdatabyte.Length);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string strResponse = streamReader.ReadToEnd();
            Console.WriteLine(strResponse);
            requestStream.Dispose();
            response.Dispose();
            responseStream.Dispose();
            streamReader.Dispose();
            return strResponse;
        }
    }
}
