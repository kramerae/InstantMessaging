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

        private void AddPerson()
        {
            List<string> a = new List<string>();

            a.Add("Matt");
            a.Add("Jason");
            a.Add("Steven");
            _userDatabase.Add("sriegodedios", new User_m("sriegodedios", "shaner26", a));




        }





        private void WriteToFile()
        {
            string jsonString = JsonConvert.SerializeObject(_userDatabase);

            using (StreamWriter sw = new StreamWriter("users.json"))
            {
                sw.Write(jsonString);
            }
            
           // Dictionary<string, User_m> m = JsonConvert.DeserializeObject<Dictionary<string, User_m>>(jsonString);







        }

       /// <summary>
       /// This method reads from the jsonfile and adds it to the database.
       /// </summary>
        private void ReadFromFile()
        {
            using (StreamReader file = new StreamReader("users.json"))
            {
                string jsonString = file.ReadToEnd();
                _userDatabase = JsonConvert.DeserializeObject<Dictionary<string, User_m>>(jsonString);
              
            }
        }

        /// <summary>
        /// This method adds the user to the database if the user makes a new account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddUser(string username, string password)
        {
            _userDatabase.Add(username, new User_m(username, password, new List<string>()));

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

}
