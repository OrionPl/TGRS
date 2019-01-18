using System;
using System.Net.Sockets;
using System.Text;

namespace TGRS_CSharp_API
{
    public class TGRS_API
    {
        public string[] GetGameLibrary(int loginID)
        {
            SQL_Handler handler = new SQL_Handler();
            handler.SQLConnect("default", 0, "default", "default", "default");
            return handler.SQLQuery("SELECT  WHERE id=" + loginID);
        }

        public Game getGame(int gameId)
        {
            SQL_Handler handler = new SQL_Handler();
            handler.SQLConnect("default", 0, "default", "default", "games");
            string[] gameInfo = handler.SQLQuery("SELECT * FROM games WHERE gameId=" + gameId);
            Game game = new Game(int.Parse(gameInfo[0]), gameInfo[1], gameInfo[2], gameInfo[3]);
            return game;
        }

        private string ContactServer(string textToSend)
        {
            int port = 100;
            string serverIp = "127.0.0.1";
            
            TcpClient client = new TcpClient(serverIp, port);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            string ret = ASCIIEncoding.ASCII.GetString(bytesToRead);
            client.Close();
            return ret;
        }

        public string GetDatabasePassword()
        {

        }
    }
}
