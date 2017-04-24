using FP_Server.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace FP_Server
{
    public class ServerController: WebSocketBehavior
    {
        private ServerDatabase _database;
        private List<int> _chatRoom;
        private int _count = 0;

        protected override void OnOpen()
        {
                


        }


        protected override void OnMessage(MessageEventArgs e)
        {

            Delivery messageJSON = JsonConvert.DeserializeObject<Delivery>(e.Data);
            Sessions.Broadcast(messageJSON.Message);
            switch (messageJSON.TypeStatus)
            {
                case 
            }















        }
        
        public ServerController()
        {
            _database = new ServerDatabase();
            _chatRoom = new List<int>();
        }
    }
}
