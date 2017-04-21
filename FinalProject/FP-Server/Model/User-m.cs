using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    class User_m
    {
        private string _user;
        private string _password;
        private List<string> _contacts;

        public User_m(string user, string password, List<string> contacts)
        {
            _user = user;
            _password = password;
            _contacts = contacts;

        }

        public string User
        {
            get
            {
                return _password;
            }
        }

        public void AddContact(string name)
        {
            _contacts.Add(name);
        }

        public List<string> GetContacts
        {
            get
            {
                return _contacts;
            }
        }


    }
}
