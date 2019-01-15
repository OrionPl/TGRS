using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TGRS_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TGRS_Server server = new TGRS_Server();
            Thread passChanger = new Thread(new ThreadStart(server.ChangeDBPassword));
            passChanger.Start();
            
        }
    }
}
