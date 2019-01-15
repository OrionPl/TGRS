using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGRS_CSharp_API
{
    public class User
    {
        private void CreateLibrary(int id)
        {
            SQL_Handler handler = new SQL_Handler();
            handler.SQLConnect("default", 0, "default", "default", "libraries");
            handler.SQLQuery("CREATE TABLE " + id + " (`gameId` INT NOT NULL, `hoursInGame` VARCHAR(20) NOT NULL, PRIMARY KEY(`gameId`, `hoursInGame`));");
        }

        public void CreateUser(string username, string password)
        {
            SQL_Handler handler = new SQL_Handler();
            handler.SQLConnect("default", 0, "default", "default", "users");
            int newUserId = int.Parse(handler.SQLQuery("SELECT MAX(id) FROM users")[0]) + 1;
            handler.SQLQuery("INSERT INTO users (id, username, password) VALUES (" + newUserId + ", " + username + ", " + password + ")");
            CreateLibrary(newUserId);
        }

        public User()
        {
            
        }
    }
}
