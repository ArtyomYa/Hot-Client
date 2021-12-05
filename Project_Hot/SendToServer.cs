using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace Project_Hot
{
    class SendToServer
    {
        public static string RequestToServer(string str)
        {
            try
            {
                Int32 port = int.Parse("13000");
                IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                TcpClient client = new TcpClient(addressserver.ToString(), port);
                //listBox1.Items.Clear();
                //listBox1.Items.Add("Connection to server :");
                byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                string messagefromserver = "";
                data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                messagefromserver = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                str = messagefromserver;
                stream.Close();
                client.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return str;
        }
        
    }
}
