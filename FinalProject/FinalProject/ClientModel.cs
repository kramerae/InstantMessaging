using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ClientModel class
    /// </summary>
    public class ClientModel : IClientModel
    {
        private string _id;
        private string _username;
        private bool _loginStatus;
        private Dictionary<string, bool> _contactList;
        private bool _addcontact = true;
        private Dictionary<int, KeyValuePair<List<string>, List<string>>> _chatRooms; // Dictionary <chatroomid, KeyValuePair<usernames, messages>>
        private List<string> messages;


        /// <summary>
        /// Client Model constructor
        /// </summary>
        public ClientModel()
        {
            
        }

        /// <summary>
        /// Gets and sets the clients ID
        /// </summary>
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

        /// <summary>
        /// Gets and sets the cleints Username
        /// </summary>
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

        /// <summary>
        /// Gets and sets the login status
        /// </summary>
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

        /// <summary>
        /// Gets and sets the contact list
        /// </summary>
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

        /// <summary>
        /// Gets and sets the dictionary of chat rooms 
        /// Includes chat room #, users, and message history
        /// </summary>
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

        /// <summary>
        /// Gets and sets add contact field
        /// </summary>
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
