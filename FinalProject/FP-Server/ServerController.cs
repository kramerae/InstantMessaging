using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server
{
    public class ServerController
    {
        private ServerDatabase _database;

        public ServerController(ServerDatabase d)
        {
            _database = d;
        }
    }
}
