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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Collections;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
       

        private void btn1_Click(object sender, EventArgs e)
        {
            foreach(Socket item in clientList)
            {
                Send(item);
            }
            rtbsv.AppendText("\n" + txtsend.Text);
            
        }

        private const int PORT_NUMBER = 9999;
        /*private void show()
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(address, PORT_NUMBER);
                listener.Start();

                check.AppendText("Server started on " + listener.LocalEndpoint);
                check.AppendText("Waiting for a connection...");

                Socket socket = listener.AcceptSocket();
                check.AppendText("Connection received from " + socket.RemoteEndPoint);
            }
            catch
            {
            }
        }*/

        IPEndPoint ip;
        Socket server, client;
        List<Socket> clientList;
        private void Connect()
        {
            clientList = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, 13);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ip);
            Thread Lis = new Thread(() =>
            {
               
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.Start(client);
                        check.AppendText(" \n Connection received from " + client.RemoteEndPoint);
                    }
                    
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            }); 
            Lis.Start();
            
        }
      
        private void Send(Socket client)
        {
            if (client != null && txtsend.Text != string.Empty)
            {
                client.Send(Serialize(txtsend.Text));
            }
        }
        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string rev = (string)Deserialize(data);
                    foreach(Socket item in clientList)
                    {
                        if(item != null && item != client)
                        {
                            item.Send(Serialize(rev));
                        }
                    }
                    rtbsv.AppendText("\n" + rev);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
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

    }
}
