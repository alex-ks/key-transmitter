using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using KeyTransmitter.Client;

namespace KeyTransmitter.ConsoleClient
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Two arguments required: hostname and port");
                return;
            }

            try
            {
                var hostname = args[0];
                var port = int.Parse(args[1]);

                using (var transmitter = new Transmitter(hostname, port))
                {
                    var key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {
                        transmitter.SendKey(key.Key);
                        key = Console.ReadKey();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
