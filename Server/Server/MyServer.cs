using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public class MyServer
    {
        public MyServer(IPAddress ipAddress, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            endPoint = new IPEndPoint(ipAddress, port);
            socket.Bind(endPoint);
            socket.Listen(8);
        }

        public void ProcessWaitingQueue(object obj)
        {
            while (true)
            {
                Socket handler = socket.Accept();
                Parames pars = new Parames(handler, (RichTextBox)obj);               

                Thread thr = new Thread(new ParameterizedThreadStart(ProcessConnection));
                thr.Start(pars);
            }
        }


        public void ProcessConnection(object obj)
        {
            Parames pars = (Parames)obj;

            Socket skt = pars.skt;
            RichTextBox rtb = pars.rtb;
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];

            do
            {
                bytes = skt.Receive(data);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (skt.Available > 0);

            rtb.AppendText(builder.ToString());

            //string message = "ваше сообщение доставлено";
            //data = Encoding.Unicode.GetBytes(message);
            //skt.Send(data);
            skt.Shutdown(SocketShutdown.Both);
            skt.Close();
            Thread.CurrentThread.Abort();
        }

        private Socket socket { get; set; }
        private IPEndPoint endPoint { get; set; }
    }

    public class Parames
    {
        public Parames(Socket sock, RichTextBox richtb)
        {
            skt = sock;
            rtb = richtb;
        }

        public Socket skt;
        public RichTextBox rtb;
    }
}
