using FP_Server.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using ClassLibrary;

using WebSocketSharp.Server;

namespace FP_Server
{
    public class ServerController: WebSocketBehavior
    {
      //  private Status en = new Status();
        private ServerDatabase _database;
        private List<ChatRoom> _chatRoom;
        private int _count = 0;
        private List<string> users = new List<string>();
        


        protected override void OnOpen()
        {
            Packet p = new Packet(Status.onlineTrue);
            users.Add(ID);
            Sessions.SendTo(ID, JsonConvert.SerializeObject(p));

        }


        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = e.Data;
            //Sessions.Broadcast(msg);
            Packet messageJSON = JsonConvert.DeserializeObject<Packet>(e.Data);
            //Sessions.Broadcast(messageJSON.Message);

            switch (messageJSON.GetStatus)
             {
                 case Status.loginValidate:
                    {
                        Authentication(messageJSON);
                        break;
                    }
                 case Status.messageSend:
                     {
                        string message = messageJSON.Message;

                        


                         break;
                     }











             }



            










        }


        
        public ServerController()
        {
            _database = new ServerDatabase();
            _chatRoom = new List<ChatRoom>();
        }


        /// <summary>
        /// This method excutes the authentication of the user
        /// </summary>
        /// <param name="messageJSON"></param>
        private void Authentication(Packet messageJSON)
        {

            if (!_database.CheckUser(messageJSON.Username))
            {
                //User does not exsist

                _database.AddUser(messageJSON.Username, messageJSON.Password);

                // Logins the user
                Delivery s1 = new Delivery(Status.loginTrue);
                SendMessage(ID, s1);

               


            }
            else
            {
                //User exsists

                if (!_database.PasswordValidation(messageJSON.Username, messageJSON.Password))
                {
                    //Password is incorrect
                    Sessions.Broadcast(JsonConvert.SerializeObject(new Delivery(Status.loginFalse)));

                }
                else
                {
                    //Password is correct
                    Sessions.Broadcast(JsonConvert.SerializeObject(new Delivery(Status.loginTrue)));
                }

            }
            
        }

        private void SendMessage(string id, Delivery d)
        {
            Sessions.SendTo(id, JsonConvert.SerializeObject(d));
        }

    
    }
}
