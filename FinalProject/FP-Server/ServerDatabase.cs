using FP_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FP_Server
{
    class ServerDatabase
    {
        Dictionary<string, User_m> _userDatabase;
        
        public ServerDatabase()
        {
            _userDatabase = new Dictionary<string, User_m>();
        }

        private void ReadFromFile()
        {
            using (StreamReader json = new StreamReader("users.json"))
            {

            }
        }


    }
}
