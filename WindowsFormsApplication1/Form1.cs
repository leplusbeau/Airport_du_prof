using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHost
{
    public partial class Form1 : Form
    {
        System.ServiceModel.ServiceHost host;

        public Form1()
        {
            InitializeComponent();

            host = new System.ServiceModel.ServiceHost(typeof(Airport.Service.AirportService));
            this.label2.Text = host.State.ToString();
            host.Closed += new EventHandler(host_closed);
            host.Closing += new EventHandler(host_Closing);
            host.Faulted += new EventHandler(host_faulted);
            host.Opening += new EventHandler(host_Opening);
            host.Opened += new EventHandler(host_Opened);
        }

        private void host_Opened(object sender, EventArgs e)
        {
            this.label2.Text = host.state.ToString();
        }

        private void host_Closing(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void host_Opening(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void host_closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void host_faulted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
