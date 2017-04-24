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
        
        public Delivery(string chatID)
        {
            _chatID = chatID;
            _status = Status.ConSuccess;
            _message = null;
            _chatroom = -100;
            _username = null;
            _password = null;
        }

        public Delivery(Status status, string username, string password)
        {
            _status = status;
            _username = username;
            _password = password;
            _message = null;
            _chatroom = -100;


        }

        public Delivery(Status status)
        {
            _status = status;
            _username = null;
            _password = null;
            _message = null;
            _chatroom = -100;
        }

        public Delivery(Status status, string message, int chatroom)
        {
            _status = status;
            _message = message;
            _chatroom = chatroom;
            _username = null;
            _password = null;
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get
            {
                return _password;
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
            }
        }

        public int Chatroom
        {
            get
            {
                return _chatroom;
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
