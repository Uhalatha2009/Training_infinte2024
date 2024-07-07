using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using RemotingServer;



namespace RemoteWindowClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpChannel c = new HttpChannel(8003);
            ChannelServices.RegisterChannel(c);


            //create a service class object (that is the proxy for the remote object)
            RemoteServices rserviceproxy = (RemoteServices)Activator.GetObject(typeof(RemoteServices),
                "http://localhost:86/OurRemoteServices");
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label3.Text = "The max number is :" + rserviceproxy.WriteMessage(x, y);

        }
    }
}
