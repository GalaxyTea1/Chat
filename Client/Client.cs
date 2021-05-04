using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Receive();
           
            CheckForIllegalCrossThreadCalls = false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Send();
            rtb1.AppendText("\n" + txt1.Text);

        }

        IPEndPoint ip;
        Socket client;
        private void Connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {

                client.Connect(ip);
                MessageBox.Show("Connected", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.Start();
        }
       
        private void Send()
        {
            try
            {
                
                {

                }
                if (txt1.Text != string.Empty)
                {
                    client.Send(Serialize(txt1.Text));
                }
            }
            catch { }
        }
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string s = (string)Deserialize(data);
                    rtb1.AppendText("\n" + s);
                }
            }
            catch
            {}
        }
      
        byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                client.Close();
                client.Disconnect(true);
                if (client == null)
                {
                    MessageBox.Show("Disconnected", "Thông báo");
                }
                
            }
            catch { }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
             Connect();
        }
    }
}
