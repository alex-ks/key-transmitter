using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KeyTransmitter.Client
{
    public class Transmitter : IDisposable
    {
        private TcpClient client;
        private Stream tcpStream;

        public Transmitter(string host, int port)
        {

              client = new TcpClient("192.168.2.190", port);
            //client = new TcpClient("172.16.0.100", port);
            tcpStream = client.GetStream();
            
        }

        public void SendKey(ConsoleKey key)
        {
            tcpStream.Write(BitConverter.GetBytes((int)key), 0, sizeof(int));
        }
        public void SendInt(int key)
        {
            tcpStream.Write(BitConverter.GetBytes(key), 0, sizeof(int));
        }
        public void Send4Int(int key, int key2,int key3,int key4)
        {
           // key = 1;key2 = 2;key3 = 3;key4 = 4;
            byte[] newArray = new byte[16];//array1.Length
            Array.Copy(BitConverter.GetBytes(key), newArray, 4);
            Array.Copy(BitConverter.GetBytes(key2), 0, newArray, 4, 4);
           Array.Copy(BitConverter.GetBytes(key3), 0, newArray, 8, 4);
            Array.Copy(BitConverter.GetBytes(key4), 0, newArray, 12, 4);

            tcpStream.Write(newArray, 0, 16);// 4*sizeof(int));
            //tcpStream.Write(), 0, sizeof(int));
            //tcpStream.Write(BitConverter.GetBytes(key3), 0, sizeof(int));
            //tcpStream.Write(BitConverter.GetBytes(key4), 0, sizeof(int));
        }


        public Task SendKeyAsync(ConsoleKey key)
        {
            return tcpStream.WriteAsync(BitConverter.GetBytes((int)key), 0, sizeof(int));
        }

        public void Dispose()
        {
            client.Close();
        }
    }
}
//