using System;
using System.Windows.Forms;
using Server.Properties;
using Classes;

namespace Server
{
    public partial class FormMain : Form
    {
        TStorage Storage;
        TTransport Transport;

        public FormMain()
        {
            InitializeComponent();
            Transport = new TTransport();
            Transport.Updated += new TransportEvent(Transport_Updated);
            
            Storage = new TStorage(Settings.Default.Database);
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            Transport.ReadMessages();
        }

        void Transport_Updated(string Message)
        {
            LabelStatus.Text = Message;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
