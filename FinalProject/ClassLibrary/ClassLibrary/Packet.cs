using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Packet
    {
        Status _status;
        string _username;
        string _password;
        string _message;
        List<string> _messageHistory;
        Dictionary<string,bool> _contactList;
        string _destinationID;
        string _originID;
        string _ID;

        public Packet(Status status)
        {
            _status = status;
            _messageHistory = new List<string>();
        }

        public Status GetStatus
        {
            get
            {
                return _status;
            }set
            {
                _status = value;
            }
        }
        /// <summary>
        /// This is property for the username
        /// </summary>
        public string Username
        {
            get
            {
                return _username;
            }set
            {
                _username = value;
            }
        }

        /// <summary>
        /// This is the property for the password
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        /// <summary>
        /// This is the property for the Message
        /// </summary>
        public string Message
        {
            get
            {
                return _message;
            }set
            {
                _message = value;
            }
        }

        /// <summary>
        /// This is property for the MessageList
        /// </summary>
        public List<string> MessageHistory
        {
            get
            {
                return _messageHistory;

            }set
            {
                _messageHistory = value;
            }
        }

        /// <summary>
        /// This is a property for the contact list
        /// </summary>
        public Dictionary<string,bool> ContactList
        {
            get
            {
                return _contactList;
            }set
            {
                _contactList = value;
            }
        }

        public string OriginID
        {
            get{
                return _originID;
            }set{
                _originID = value;
            }
        }

        public string DestinationID
        {
            get{
                return _destinationID;
            }set{
                _destinationID = value;
            }
        }

        public string GetID
        {
            get{
                return _ID;

            }set{
                _ID = value;
            }
        }



       








    }
}
