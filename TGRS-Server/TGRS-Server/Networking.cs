using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TGRS_CSharp_API;

namespace TGRS_Server
{

    class Networking
    {
        public async void ReceiveSendSocket()
        {
            while (true)
            {
                IPAddress localAdd = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(localAdd, 100);
                Console.WriteLine("Listening...");
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();

                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received : " + dataReceived);

                if (dataReceived.StartsWith("up "))
                {
                    char[] dat = dataReceived.Remove(0, 3).ToCharArray();
                    string username = "";
                    string password = "";
                    bool p = false;

                    foreach (var v in dat)
                    {
                        if (v != ' ')
                        {
                            if (p == false)
                            {
                                username += v;
                            }
                        }
                        else
                        {
                            password += v;
                        }
                    }

                    SQL_Handler handler = new SQL_Handler();
                    handler.SQLConnect("localhost", 3306, "localadmin", "localadminpassword", "passwords");

                    if (handler.SQLQuery("SELECT password FROM passwords WHERE mail=" + username)[0] == password)
                    {
                        Console.WriteLine("Sending back : login accepted");
                        nwStream.Write(buffer, 0, byte.Parse(handler.SQLQuery("SELECT password FROM mysql")[0]));
                    }
                }
                client.Close();
            }
        }
    }
}
