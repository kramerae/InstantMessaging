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
      //  private Status en = new Status();
        private ServerDatabase _database;
        private List<ChatRoom> _chatRoom;
        private int _count = 0;
        


        protected override void OnOpen()
        {
            Delivery d = new Delivery(Status.ConSuccess);
            d.ChatID = ID;
            Sessions.SendTo(ID, JsonConvert.SerializeObject(d));

        }


        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = e.Data;
            Sessions.Broadcast(msg);
            Delivery messageJSON = JsonConvert.DeserializeObject<Delivery>(e.Data);
            Sessions.Broadcast(messageJSON.Message);

            switch (messageJSON.TypeStatus)
             {
                 case Status.LoginRequest:
                    {
                        //An authentication rquest is request
                        Authentication(messageJSON);
                        break;
                    }
                 case Status.SendMessage:
                     {
                        string id = messageJSON.
                        SendMessage()
                        


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
                Delivery s1 = new Delivery(Status.loginSuccess);
                SendMessage(ID, s1);

               


            }
            else
            {
                //User exsists

                if (!_database.PasswordValidation(messageJSON.Username, messageJSON.Password))
                {
                    //Password is incorrect
                    Sessions.Broadcast(JsonConvert.SerializeObject(new Packet(Status.loginFalse)));

                }
                else
                {
                    //Password is correct
                    Sessions.Broadcast(JsonConvert.SerializeObject(new Packet(Status.loginSuccess)));
                }

            }
            
        }

        ///<summary>
        /// This method sends a message to a specified client
        ///</summary>
        ///<param name="id">The id to send</param>
        ///<param name="d">The packet to send</param>
        private void SendMessage(string id, Delivery d)
        {
            Delivery temp = new Delivery(Status.messageRecieved);
            temp.Message = d.Message;

            Sessions.SendTo(id, JsonConvert.SerializeObject(temp));
        }

    
    }
}
