using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    public class Delivery
    {
        Status _status; // 101 = request loggin, 200 login succesfull, 403 loggin invalid, 201 send message
        string _message;
        string _chatID;
        int _chatroom;
        string _username;
        string _password;
        
        public Delivery(Status status)
        {
            _status = status;
        }

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

        public Status TypeStatus
        {
            get
            {
                return _status;
            }
        }

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

        public int Chatroom
        {
            get
            {
                return _chatroom;
            }set
            {
                _chatroom = value;
            }
        }

        public string ChatID
        {
            get
            {
                return _chatID;
            }
            set
            {
                _chatID = value;
            }
        }

    }
}
