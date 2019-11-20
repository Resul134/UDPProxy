using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using Newtonsoft.Json;

namespace UDPProxy
{
    internal class Worker
    {
        private const int PORT = 10100;

        public async void Start()
        {
            UdpClient client = new UdpClient(PORT);

            Console.WriteLine("UDP receiver started på port" + PORT);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, PORT);

            using (HttpClient c = new HttpClient())
            {

                while (true)
                {
                    byte[] bytes = client.Receive(ref endpoint);

                    string str = Encoding.UTF8.GetString(bytes);



                    StringContent content = new StringContent(str, Encoding.UTF8, "application/json");


                    await c.PostAsync("https://localhost:44317/api/Sensor", content);

                    Console.WriteLine("Modtaget: " + str);
                }

            }
        }
    }
}
