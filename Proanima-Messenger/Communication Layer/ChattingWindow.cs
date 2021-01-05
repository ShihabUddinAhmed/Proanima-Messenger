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
using Proanima_Messenger.Entities;
using Proanima_Messenger.Presentation_Leyar;
using System.IO;

namespace Proanima_Messenger.Communication_Layer
{
    public partial class ChattingWindow : Form
    {
        Socket socket;
        EndPoint endPointLocal, endPointRemote;
        byte[] buffer;
        User user;
        HomePage back;
        string connectionStatus = "Disconnected", localUser, remoteUser;
        int localPort, remotePort;

        public string LocalUser { get => localUser; set => localUser = value; }
        public string RemoteUser { get => remoteUser; set => remoteUser = value; }
        public int LocalPort { get => localPort; set => localPort = value; }
        public int RemotePort { get => remotePort; set => remotePort = value; }

        public void ReceiverName(string name)
        {
            messageLabel.Text = name;
        }

        public ChattingWindow(User user, HomePage back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
        }

        public string GetLocalIP()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in iPHostEntry.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return iPAddress.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectionStatus != "Connected")
                {
                    endPointLocal = new IPEndPoint(IPAddress.Parse(LocalUser), LocalPort);
                    socket.Bind(endPointLocal);

                    endPointRemote = new IPEndPoint(IPAddress.Parse(RemoteUser), RemotePort);
                    socket.Connect(endPointRemote);

                    buffer = new byte[2000];
                    socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(MessageCallBack), buffer);
                    connectionStatus = "Connected";
                    connectButton.Text = "Connected";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Connection Error!\n" + exc.Message);
            }
        }

        private void ChattingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            back.DeleteChat();
            Application.Exit();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] sendingMessage = aSCIIEncoding.GetBytes(sendTextBox.Text);
            socket.Send(sendingMessage);
            messageListBox.Items.Add(user.Name + ": " + sendTextBox.Text);
            sendTextBox.Text = string.Empty;
        }

        private void ChattingWindow_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        private void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                byte[] receivedData = new byte[2000];
                receivedData = (byte[])asyncResult.AsyncState;
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string receivedMessage = aSCIIEncoding.GetString(receivedData);

                messageListBox.Items.Add(messageLabel.Text + ": " + receivedMessage);
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Communication Error!");
            }
        }

        public void SetProfilePicture(byte[] profilePicture)
        {
            if (profilePicture != null)
            {
                MemoryStream memoryStream = new MemoryStream(profilePicture);
                profilePictureBox.Image = Image.FromStream(memoryStream);
            }
        }
    }
}
