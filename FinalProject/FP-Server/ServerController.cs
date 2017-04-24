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
        

        protected override void OnMessage(MessageEventArgs e)
        {

            Delivery messageJSON = JsonConvert.DeserializeObject<Delivery>(e.Data);
            Send("Echo: " + messageJSON.Message);

        }
        
        public ServerController()
        {
            _database = new ServerDatabase();
        }

    }
}
