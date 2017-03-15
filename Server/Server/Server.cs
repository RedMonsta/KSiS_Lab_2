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
using System.Net.Sockets;
using System.Threading;


namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            server = new MyServer(IPAddress.Parse("127.0.0.1"), 10000);
            rtbMsg.AppendText("started");
            
            waithr = new Thread(new ParameterizedThreadStart(server.ProcessWaitingQueue));
            waithr.Start(rtbMsg);
        }

        /*~Server()
        {
            waithr.Abort();   
        }*/

        private MyServer server;
        private Thread waithr;

        private void btnStartServ_Click(object sender, EventArgs e)
        {
            //waithr.Abort();
        }
    }
}
