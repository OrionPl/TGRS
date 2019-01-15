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

        //public string SocketSendReceive()
        //{
        //    string request = "GET / HTTP/1.1\r\nHost: " + server +
        //                     "\r\nConnection: Close\r\n\r\n";
        //    Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
        //    Byte[] bytesReceived = new Byte[256];
            
        //    using (Socket s = ConnectSocket(server, port))
        //    {

        //        if (s == null)
        //            return ("Connection failed");
                
        //        s.Send(bytesSent, bytesSent.Length, 0);
                
        //        int bytes = 0;
        //        string page = "Default HTML page on " + server + ":\r\n";
                
        //        do
        //        {
        //            bytes = s.Receive(bytesReceived, bytesReceived.Length, 0);
        //            page = page + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
        //        }
        //        while (bytes > 0);
        //    }
        //}
    }
}
