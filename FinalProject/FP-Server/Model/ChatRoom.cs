using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    public class ChatRoom
    {
        private List<string> _usernames;
        private List<string> _messageHistory;
        private int _roomID;


        public ChatRoom(int i)
        {
            _roomID = i;
            _usernames = new List<string>();
            _messageHistory = new List<string>();
        }

        public void AddUser(string username)
        {
            _usernames.Add(username);
        }

        public void AddMessage(string message)
        {
            _messageHistory.Add(message);
        }

        
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
    }
}
