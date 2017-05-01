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
            client = new TcpClient(host, port);
            tcpStream = client.GetStream();
        }

        public void SendKey(ConsoleKey key)
        {
            tcpStream.Write(BitConverter.GetBytes((int)key), 0, sizeof(int));
        }

        public async Task SendKeyAsync(ConsoleKey key)
        {
            await tcpStream.WriteAsync(BitConverter.GetBytes((int)key), 0, sizeof(int));
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
