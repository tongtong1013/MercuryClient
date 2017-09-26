using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Net.NetworkInformation;

namespace Mercury
{
    public class SocketClient
    {
        private string _host;
        private int _port;
        private Socket _clientSocket = null;

        public SocketClient()
        {
            _host = GetIPAddress();
            _port = GetPort();
            ConnectServer();
        }

        public SocketClient(string host)
        {
            _host = host;
            _port = GetPort();
            ConnectServer();
        }

        public SocketClient(string host, int port)
        {
            _host = host;
            _port = port;
            ConnectServer();
        }

        private string GetIPAddress()
        {
            string ipAdd = "";
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAdd = _IPAddress.ToString();
                }
            }
            return ipAdd;
        }

        private int GetPort()
        {
            int MAX_PORT = 65535; //系统tcp/udp端口数最大是65535            
            int BEGIN_PORT = 50000;//从这个端口开始检测
            for (int i = BEGIN_PORT; i < MAX_PORT; i++)
            {
                if (PortIsAvailable(i))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool PortIsAvailable(int port)
        {
            bool isAvailable = true;
            IList portUsed = PortIsUsed();
            foreach (int p in portUsed)
            {
                if (p == port)
                {
                    isAvailable = false; break;
                }
            }
            return isAvailable;
        }

        private IList PortIsUsed()
        {
            //获取本地计算机的网络连接和通信统计数据的信息
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            //返回本地计算机上的所有Tcp监听程序
            IPEndPoint[] ipsTCP = ipGlobalProperties.GetActiveTcpListeners();
            //返回本地计算机上的所有UDP监听程序
            IPEndPoint[] ipsUDP = ipGlobalProperties.GetActiveUdpListeners();
            //返回本地计算机上的Internet协议版本4(IPV4 传输控制协议(TCP)连接的信息。
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();
            IList allPorts = new ArrayList();
            foreach (IPEndPoint ep in ipsTCP)
            {
                allPorts.Add(ep.Port);
            }
            foreach (IPEndPoint ep in ipsUDP)
            {
                allPorts.Add(ep.Port);
            }
            foreach (TcpConnectionInformation conn in tcpConnInfoArray)
            {
                allPorts.Add(conn.LocalEndPoint.Port);
            }
            return allPorts;
        }

        private void ConnectServer()
        {
            IPAddress ip = IPAddress.Parse(_host);
            IPEndPoint ipe = new IPEndPoint(ip, _port);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IPv4);
            clientSocket.Connect(ipe);
        }

        public void SendMessage(string msg)
        {
            string sendStr = "msg";
            //Console.WriteLine(sendStr);
            byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
            _clientSocket.Send(sendBytes);
        }

        public string ReceiveMessege()
        {
            string recStr = "";
            byte[] recBytes = new byte[4096];
            int bytes = _clientSocket.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            //Console.WriteLine(recStr)
            return recStr;
        }

        public void CloseSocket()
        {
            _clientSocket.Close();
        }

        ~SocketClient()
        {
            if (null != _clientSocket)
            {
                _clientSocket.Close();
                _clientSocket.Dispose();
                _clientSocket = null;
            }
        }
    }
}
