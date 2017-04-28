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
        private ServerDatabase _database; //= new ServerDatabase();
        private List<ChatRoom> _chatRoom;
        private int _count = 0;

        public ServerController()
        {
            _database = new ServerDatabase();
            _chatRoom = new List<ChatRoom>();
        }


        protected override void OnOpen()
        {
           Packet p = new Packet(Status.connectionSuccess);
           p.GetID = ID;
           Sessions.SendTo(JsonConvert.SerializeObject(p), ID);

        }



        protected override void OnMessage(MessageEventArgs e)
        {


            string msg = e.Data;
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
                        SendMessage(messageJSON.OriginID, messageJSON.DestinationID, messageJSON.Message);
                        break;
                     }
                case Status.contactListRequest:
                    {
                        //Sends a message history from a specific client.
                        Dictionary<string, bool> contacts = _database.GetContacts(messageJSON.OriginID);

                        Packet p = new Packet(Status.contactListSend);
                        p.ContactList = contacts;
                        p.DestinationID = messageJSON.OriginID;
                        p.OriginID = "server";

                        Sessions.SendTo(p.DestinationID, JsonConvert.SerializeObject(p));

                        break;
                    }
                case Status.connectionSuccess:
                    Authentication(messageJSON);
                    break;


             }



            










        }


        
      


        /// <summary>
        /// This method excutes the authentication of the user
        /// </summary>
        /// <param name="messageJSON"></param>
        private void Authentication(Packet messageJSON)
        {
            string id = messageJSON.GetID;

            if (!_database.CheckUser(messageJSON.Username))
            {
                //User does not exsist

                _database.AddUser(messageJSON.Username, messageJSON.Password, messageJSON.GetID);


                // Logins the user
                Packet s1 = new Packet(Status.loginTrue);
                Sessions.SendTo(JsonConvert.SerializeObject(s1), id);





            }
            else
            {
                //User exsists

                if (!_database.PasswordValidation(messageJSON.Username, messageJSON.Password))
                {
                    //Password is incorrect
                    Sessions.SendTo(JsonConvert.SerializeObject(new Packet(Status.loginFalse)),id);

                }
                else
                {
                    //Password is correct
                    Sessions.SendTo(JsonConvert.SerializeObject(new Packet(Status.loginTrue)),id);
                }

            }
            
        }

        ///<summary>
        /// This method sends a message to a specified client
        ///</summary>
        ///<param name="id">The id to send</param>
        ///<param name="d">The packet to send</param>
        private void SendMessage(string idOrigin, string idDestination, string message)
        {
            Packet temp = new Packet(Status.messageReceive);
            temp.Message = message;
            temp.OriginID = idOrigin;
            temp.DestinationID = idDestination;

            Sessions.SendTo(JsonConvert.SerializeObject(temp),idDestination);
        }

    
    }
}
