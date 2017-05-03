using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    //ClientModel class
    public class ClientModel : IClientModel
    {
        private string _id;
        private string _username;
        private bool _loginStatus;
        private Dictionary<string, bool> _contactList;
        private bool _addcontact = true;

        
        private Dictionary<int, KeyValuePair<List<string>, List<string>>> _chatRooms; // Dictionary <chatroomid, KeyValuePair<usernames, messages>>
        private List<string> messages;
        
        
        //Client Model constructor
        public ClientModel()
        {
            
        }
        
        //Gets and sets the ID
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

        //Gets and sets the Username
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

        //Gets and sets the login status
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

        //Gets and sets the contact list
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

        //gets and sets the dictionary of chat rooms
        public Dictionary<int, KeyValuePair<List<string>, List<string>>> ChatRooms
        {
            get
            {
                return _chatRooms;
            }
            set
            {
                _chatRooms = value; 
            }
        }

        //gets and sets add contact field
        public bool AddContact
        {
            get
            {
                return _addcontact;
            }
            set
            {
                _addcontact = value;
            }
        }

         

    }
}
