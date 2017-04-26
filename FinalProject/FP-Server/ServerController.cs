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
        


        protected override void OnOpen()
        {
           // Delivery d = new Delivery(Status.ConSuccess);
           // d.ChatID = ID;
           // Sessions.SendTo(ID, JsonConvert.SerializeObject(d));

        }


        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = e.Data;
            Sessions.Broadcast(msg);
            Packet messageJSON = JsonConvert.DeserializeObject<Packet>(e.Data);
            Sessions.Broadcast(messageJSON.Message);

            switch (messageJSON.GetStatus)
             {
                 case Status.loginValidate:
                    {
                        //An authentication rquest is request
                        Authentication(messageJSON);
                        break;
                    }
                 case Status.messageSend:
                     {
                        //Send message to a specific client
                        string id = messageJSON.DestinationID;
                        SendMessage(id, messageJSON);

                         break;
                     }
                case Status.contactListRequest:
                    {
                        //Sends a message history from a specific client.
                        _database.
                        


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
                Packet s1 = new Packet(Status.loginFalse);
                Sessions.SendTo(messageJSON.DestinationID, JsonConvert.SerializeObject(s1));





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
                    Sessions.Broadcast(JsonConvert.SerializeObject(new Packet(Status.loginTrue)));
                }

            }
            
        }

        ///<summary>
        /// This method sends a message to a specified client
        ///</summary>
        ///<param name="id">The id to send</param>
        ///<param name="d">The packet to send</param>
        private void SendMessage(string id, Packet p)
        {
            Packet temp = new Packet(Status.messageReceive);
            temp.Message = p.Message;

            Sessions.SendTo(id, JsonConvert.SerializeObject(temp));
        }

    
    }
}
