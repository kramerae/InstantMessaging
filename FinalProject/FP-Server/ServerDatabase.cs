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

        /// <summary>
        /// Checks if the user exsist
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckUser(string username)
        {
            return _userDatabase.ContainsKey(username);
        }



        /// <summary>
        /// Checks if the password is correct
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool PasswordValidation(string username, string password)
        {
            string dbPassword = _userDatabase[username].Password;

            if(password == dbPassword)
            {
                return true;
            }

            return false;




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
