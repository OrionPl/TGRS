using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using TGRS_CSharp_API;

namespace TGRS_Server
{
    class TGRS_Server
    {
        public void ChangeDBPassword()
        {
            while (true)
            {
                const string allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                Random rng = new Random();
                int minLength = 30;
                int maxLength = 60;
                int count = 1;

                char[] chars = new char[maxLength];
                int setLength = allowedChars.Length;

                while (count-- > 0)
                {
                    int length = rng.Next(minLength, maxLength + 1);

                    for (int i = 0; i < length; ++i)
                    {
                        chars[i] = allowedChars[rng.Next(setLength)];
                    }
                }

                string newPassword = chars.ToString();
                SQL_Handler handler = new SQL_Handler();
                handler.SQLConnect("localhost", 3306, "thelocaladmin", "thelocaladminpassword", "mysql");
                handler.SQLQuery("ALTER LOGIN somerandomusername WITH PASSWORD = '" + newPassword + "'");
                Thread.Sleep(1000 * 60 * 1);
            }
        }
    }
}
