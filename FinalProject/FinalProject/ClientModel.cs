using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ClientModel : IClientModel
    {
        private string _id;
        private string _username;
        private bool _loginStatus;
        private Dictionary<string, bool> _contactList;
        private List<string> messages;
        
        //test

        public ClientModel()
        {
            
        }
        
    
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public bool LoginStatus
        {
            get
            {
                return _loginStatus;
            }
            set
            {
                _loginStatus = value;
            }
        }

        public Dictionary<string, bool> ContactList
        {
            get
            {
                return _contactList;
            }
            set
            {
                _contactList = value;
            }
        }


         

    }
}
