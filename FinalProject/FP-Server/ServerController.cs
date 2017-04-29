using FP_Server.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using System.Windows.Forms;
using ClassLibrary;

using WebSocketSharp.Server;

namespace FP_Server
{
   
    public class ServerController: WebSocketBehavior
    {

        event UpdateEvent _u;
        //  private Status en = new Status();
        private ServerDatabase _database; //= new ServerDatabase();
        private List<ChatRoom> _chatRoom;
        private int _count = 0;
        private ServerForm _sf;
       

        public ServerController(UpdateEvent ue, ServerForm sf)
        {
            _u = ue;
            _database = new ServerDatabase();
            _chatRoom = new List<ChatRoom>();
            _sf = sf;

           // sf.ShowDialog();
        }


        protected override void OnOpen()
        {

           Packet p = new Packet(Status.connectionSuccess);
           p.GetID = ID;
         
            // MessageBox.Show("New user with Identification of: " + ID);
            Sessions.SendTo(JsonConvert.SerializeObject(p), ID);
            _u("New user with Identification of: " + ID);

            // _u("New user with Identification of: "+ID);

        }

        


        protected override void OnMessage(MessageEventArgs e)
        {

            Status test = ConvertTos.ConvertToStatus(4);


            string msg = e.Data;
            Packet messageJSON = JsonConvert.DeserializeObject<Packet>(e.Data);
          
            

            int test2 = ConvertTos.ConvertToInt(messageJSON.GetStatus);
           // Sessions.Broadcast(messageJSON.Message);

            //int type = 




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

                        Sessions.SendTo(JsonConvert.SerializeObject(p), messageJSON.GetID);

                        break;
                    }
                case Status.connectionSuccess:
                    //Authentication(messageJSON);
                    MessageBox.Show("Incorrect =(");
                    break;
                case Status.requestChatRoom:
                    {

                        //Makes a new Chatroom for the user
                        NewChatRoom(messageJSON);
                        break;

                    }
                case Status.loginTrue:
                    MessageBox.Show("This is correct. =)");
                    break;
                 
                    

             }



            










        }


        
      


        /// <summary>
        /// This method excutes the authentication of the user
        /// </summary>
        /// <param name="messageJSON"></param>
        private void Authentication(Packet messageJSON)
        {
            _u("Request Authentication-- ID: " + messageJSON.GetID);
            string id = messageJSON.GetID;

            if (!_database.CheckUser(messageJSON.Username))
            {
                //User does not exsist

                _database.AddUser(messageJSON.Username, messageJSON.Password, messageJSON.GetID);


                // Logins the user
                Packet s1 = new Packet(Status.loginTrue);
                s1.GetID = id;
                s1.GetStatus = Status.loginTrue;
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


        private void NewChatRoom(Packet p)
        {
            ChatRoom c = new ChatRoom(_count);
            c.AddUser(p.GetID);
            c.AddUser(p.DestinationID);

            _chatRoom.Add(c);

            _count++;


        }

    
    }
}
