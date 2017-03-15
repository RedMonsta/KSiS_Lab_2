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

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            client = new MyClient(IPAddress.Parse("127.0.0.1"), 10000);
            //rtbMsg.AppendText("started");

        }

        private MyClient client; 

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbSend.Text;
            client.Sending(message);
            tbSend.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            client.Stop();
        }
    }
}
