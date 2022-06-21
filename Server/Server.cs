using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            connect();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        void connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 14000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread receive1 = new Thread(receive);
                        receive1.IsBackground = true;
                        receive1.Start(client);

                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 14000);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });

            listen.IsBackground = true;
            listen.Start();

        }

        void close()
        {
            server.Close();
        }

        void receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    client.Receive(data);

                    Bitmap img = (Bitmap)deseriablize(data);

                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(serialize(img));
                        }
                    }
                    updateImg(img);
                }
            }
            catch
            {
                // clientList.Remove(client);
                // client.Close();
            }
        }

        void updateImg(Bitmap img)
        {
            this.pic.Image = img;
        }

        byte[] serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object deseriablize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }

    }
}
