using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    //Class ChatRoom
    public class ChatRoom
    {
        private List<string> _usernames; //list of usernames
        private List<string> _messageHistory; //list of messages
        private int _roomID; 
        private Dictionary<string, string> _idRef;

        //Constructor for the ChatRoom class
        public ChatRoom(int i)
        {
            _roomID = i;
            _usernames = new List<string>();
            _messageHistory = new List<string>();
        }

        //Adds user to the chatroom
        public void AddUser(string username)
        {
            _usernames.Add(username);
        }

        //Adds message to messageHistory
        public void AddMessage(string message)
        {
            _messageHistory.Add(message);
        }

        //returns the messagehistory
        public List<string> MessageHistory
        {
            get
            {
                return _messageHistory;
            }
        }

        //Checks if a user exsists
        public bool UserExsist(string username)
        {
            for(int i = 0; i < _usernames.Count; i++)
            {
                if(username == _usernames[i])
                {
                    return true;
                }
            }
            return false;
        }

        //Gets the list of usernames
        public List<string> GetUsers
        {
            get
            {
                return _usernames;
            }           
        }

        //Returns the number of users 
        public int NumberOfUsers
        {
            get
            {
                return _usernames.Count;
            }
        }

    }
}
