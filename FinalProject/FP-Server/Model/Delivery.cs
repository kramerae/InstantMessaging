using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Server.Model
{
    public class Delivery
    {
        string _message;
        int _chatroom;

        public Delivery(string message, int chatroom)
        {
            _message = message;
            _chatroom = chatroom;
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
