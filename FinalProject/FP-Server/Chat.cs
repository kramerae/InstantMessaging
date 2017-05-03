using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace FP_Server
{
    class Chat:WebSocketBehavior
    {
        private Queue<string> _storage = new Queue<string>();
        protected override void OnOpen()
        {
            if (_storage.Count != 0)
            {
                foreach (string s in _storage)
                {
                    string temp = _storage.Dequeue();
                    Sessions.Broadcast(temp);
                }
            }
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            // Retrieve message from client
            string msg = e.Data;

            // Broadcast message to all clients
            Sessions.Broadcast(msg);
        }
    }
}
