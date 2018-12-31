using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TGRS_CSharp_API
{
    class SQL_Handler
    {
        public string lastErrorMsg = "";

        public string SQLQuery(string ip, int port, string user, string password, string database)
        {
            MySqlConnection sql = new MySqlConnection();
            sql.ConnectionString = "server=" + ip + ";port=" + port + ";uid=" + user + ";password=" + password + ";database=" + database + ";";
            MySqlCommand cmd = sql.CreateCommand();

            sql.Open();

            return "";
        }

        private void SQLError()
        {

        }
    }
}
