using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    public class Delivery
    {
        int _status; // 101 = request loggin, 200 login succesfull, 403 loggin invalid, 201 send message
        string _message;
        int _chatroom;
        string _username;
        string _password;

        public Delivery(int status, string username, string password)
        {
            _status = status;
            _username = username;
            _password = password;
            _message = null;
            _chatroom = -100;


        }

        public Delivery(int status, string message, int chatroom)
        {
            _status = status;
            _message = message;
            _chatroom = chatroom;
            _username = null;
            _password = null;
        }


        public int TypeStatus
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

    }
}
