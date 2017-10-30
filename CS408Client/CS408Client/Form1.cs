using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS408Client
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Disconnect button
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to disconnect?", "Disconnect from server", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            client.Close();
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client.Connect(ipTextBox.Text, Convert.ToInt32(portTextBox.Text));

            // TODO: Add check blank user name functions

            try
            {
                byte[] buffer = new byte[64];
                buffer = Encoding.Default.GetBytes(usernameTextBox.Text);
                client.Send(buffer);

                byte[] msgBuffer = new byte[64];
                client.Receive(msgBuffer);

                string checkClientID = Encoding.Default.GetString(msgBuffer);
                checkClientID = checkClientID.Substring(0, checkClientID.IndexOf("\0"));

                if (checkClientID == "exits")
                {
                    logTextBox.Text = logTextBox.Text + "User rejected. \n";
                }
                else
                {
                    //Add receive
                    logTextBox.Text = logTextBox.Text + "User connected. \n";
                    connectButton.Enabled = false;
                    portTextBox.Enabled = false;
                    usernameTextBox.Enabled = false;
                    ipTextBox.Enabled = false;
                }
            }
            catch
            {
                logTextBox.Text = logTextBox.Text + "Cannot connect to the server. \n";
                return;
            }
        }
        private void Receive()
        {
            bool connected = true;

            while (connected)
            {
                try
                {
                    byte[] buffer = new byte[64];
                    int checkConnection = client.Receive(buffer);

                    if (checkConnection <= 0)
                    {
                        throw new SocketException();
                    }
                    else
                    {
                        string serverMsg = Encoding.Default.GetString(buffer);
                        serverMsg = serverMsg.Substring(0, serverMsg.IndexOf("\0"));
                        logTextBox.Text = logTextBox.Text + ("List of players: " + "\n" + serverMsg + "\n");

                    }
                }
                catch
                {
                    logTextBox.Text = logTextBox.Text + "Connection lost\n ";
                    connected = false;
                    client.Close();
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes("userlist");
            client.Send(buffer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
