using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TGRS_CSharp_API
{
    public class SQL_Handler
    {
        public string lastErrorMsg = "";

        private string defIp = "localhost";
        private int defPort = 3306;
        private string defUser = "somerandomuser";
        private string defPassword = "somerandompassword";
        private string defDatabase = "users";

        private MySqlConnection sql;

        public SQL_Handler()
        {
            sql = new MySqlConnection();
        }

        public void SQLConnect(string ip, int port, string user, string password, string database)
        {
            if (ip == "default")
                ip = defIp;
            if (port == 0)
                port = defPort;
            if (user == "default")
                user = defUser;
            if (password == "default")
                password = defPassword;
            if (database == "default")
                database = defDatabase;

            sql.ConnectionString = "server=" + ip + ";port=" + port + ";uid=" + user + ";password=" + password + ";database=" + database + ";";

            SQLOpen();
            sql.Close();
        }

        public string[] SQLQuery(string command)
        {
            SQLOpen();

            MySqlCommand cmd = sql.CreateCommand();
            cmd.CommandText = command;
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> t = new List<string>();
                while (reader.Read())
                {
                    try
                    {
                        for (int i = 0; i > -1; i++)
                            t.Add(reader.GetString(i));
                    }
                    catch (Exception e)
                    { }
                }
                string[] ret = t.ToArray();

                sql.Close();
                return ret;
            }
            catch (Exception e)
            {
                lastErrorMsg = e.Message;
                return null;
            }
        }

        private void SQLOpen()
        {
            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                lastErrorMsg = e.ToString();
            }
        }
    }
}
