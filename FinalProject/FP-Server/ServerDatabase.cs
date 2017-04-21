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
            using (StreamReader file = new StreamReader("users.json"))
            {

                string json = file.ReadToEnd();
                dynamic result = JsonConvert.DeserializeObject(json);
                

                foreach(var user in result.users)
                {
                    string name = user.username.ToString();
                    string password = user.password.ToString();
                    var data = new List<string>();
                    foreach (var person in user.contacts)
                    {
                        data.Add(person.ToString());
                    }


                    _userDatabase.Add(name, new User_m(name, password, data));
                }

                //List<users> items = JsonConvert.DeserializeObject<List<users>>(json);

                //Deserializes object
                /*   Console.WriteLine("Working");
                   JsonSerializer serializer = new JsonSerializer();
                   users people = (users)serializer.Deserialize(file, typeof(users));

                   foreach(user u in people.data)
                   {
                       _userDatabase.Add(u.username, new User_m(u.username, u.password, u.contacts));
                   }


               }*/
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
