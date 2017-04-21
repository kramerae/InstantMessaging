using FP_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FP_Server
{
    public class ServerDatabase
    {
        Dictionary<string, User_m> _userDatabase;
        
        public ServerDatabase()
        {
            _userDatabase = new Dictionary<string, User_m>();
            ReadFromFile();
        }


       /// <summary>
       /// This method reads from the jsonfile and adds it to the database.
       /// </summary>
        private void ReadFromFile()
        {
            using (StreamReader file = File.OpenText(@"U:users.json"))
            {

                //Deserializes object
                Console.WriteLine("Working");
                JsonSerializer serializer = new JsonSerializer();
                users people = (users)serializer.Deserialize(file, typeof(users));
                
                foreach(user u in people.data)
                {
                    _userDatabase.Add(u.username, new User_m(u.username, u.password, u.contacts));
                }

               
            }
        }


    }












    public class users
    {
        public List<user> data { get; set; }

    }

    public class user
    {
        public string username { get; set;}
        public string password { get; set;}

        public List<string> contacts { get; set; }


    }

}
