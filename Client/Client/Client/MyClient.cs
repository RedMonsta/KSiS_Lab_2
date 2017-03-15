using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public class MyClient
    {
        public MyClient(IPAddress ipAddress, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            endPoint = new IPEndPoint(ipAddress, port);
            socket.Connect(endPoint);  
        }

        public void Sending(string msg)
        {
            
            byte[] data = Encoding.Unicode.GetBytes(msg);
            socket.Send(data);
        }

        public void Stop()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private Socket socket { get; set; }
        private IPEndPoint endPoint { get; set; }

    }
}
