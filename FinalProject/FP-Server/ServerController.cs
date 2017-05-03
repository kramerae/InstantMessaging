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
        private List<Observer> _registry = new List<Observer>();


        event UserListUpdates _ule;
        event UpdateEvent _u;
        event Logout _logout;
        //  private Status en = new Status();
        private ServerDatabase _database; //= new ServerDatabase();
       // private List<ChatRoom> _chatRoom;
        private int _count = 0;
        private ServerForm _sf;
        //private ServerDatabase _sd;
       

        public ServerController(UpdateEvent ue, UserListUpdates uel, ServerForm sf, Observer o, ServerDatabase sd)
        {
            _registry.Add(o);
            _u = ue;
            _ule = uel;
            _database = sd;
            //_chatRoom = new List<ChatRoom>();
            _sf = sf;
            _logout = _sf.LogoutUser;

           // sf.ShowDialog();
        }


        protected override void OnOpen()
        {

           Packet p = new Packet(Status.connectionSuccess);
           p.GetID = ID;
         
            // MessageBox.Show("New user with Identification of: " + ID);
            Sessions.SendTo(JsonConvert.SerializeObject(p), ID);
            _u("New user with ID of: " + ID);

            // _u("New user with Identification of: "+ID);

        }

       protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
            _u("[LOGOUT] User has logged out ID: "+ID);
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
                        //string id = messageJSON.DestinationID;
                        //SendMessage(messageJSON.OriginID, messageJSON.DestinationID, messageJSON.Message);

                        //Send message to all users in the chatroom

                        SendMessage(messageJSON);







                        break;
                     }
                case Status.contactListRequest:
                    {
                        SendContactList(messageJSON);
                        break;
                    }
                case Status.connectionSuccess:
                    //Authentication(messageJSON);
                    MessageBox.Show("Incorrect =(");
                    break;
                case Status.requestChatRoom:
                    {

                        //Makes a new Chatroom for the user
                        ValidateOnline(messageJSON);
                        break;

                    }
                case Status.loginTrue:
                    {
                        MessageBox.Show("This is correct. =)");
                        break;
                    }
                case Status.onlineValidate:
                    {

                        break;
                    }
                case Status.addContact:
                    {
                        AddContact(messageJSON);


                        break;
                    }
                case Status.removeContactRequest:
                    {
                        RemoveContact(messageJSON);
                        break;
                    }
                case Status.logout:
                    {

                        LogoutSession(messageJSON);



                        break;
                    }
                default:


                    //Unknown request
                    Packet s = new Packet(Status.undefined);
                    Sessions.SendTo(JsonConvert.SerializeObject(s), messageJSON.GetID);
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
             //   _database.

                // Logins the new user
                Packet s1 = new Packet(Status.loginTrue);
                s1.GetID = id;
                s1.GetStatus = Status.loginTrue;
                s1.Username = messageJSON.Username;
                Sessions.SendTo(JsonConvert.SerializeObject(s1), id);
                _ule(messageJSON.Username);
                _database.MakeUserOnline(messageJSON.Username);
                _u("Authentication new USER:" + messageJSON.Username);



            }
            else
            {
                //User exsists

                if (!_database.PasswordValidation(messageJSON.Username, messageJSON.Password))
                {
                    //Password is incorrect
                    Sessions.SendTo(JsonConvert.SerializeObject(new Packet(Status.loginFalse)),id);
                    _u("[FAILED] Authentication USER: " + messageJSON.Username+" ID: "+messageJSON.GetID);
                }
                else
                {
                    //Password is correct
                    _database.LoginUser(messageJSON.Username, messageJSON.GetID);
                    Packet p = new Packet(Status.loginTrue);
                    p.GetStatus = Status.loginTrue;
                    p.Username = messageJSON.Username;
                    _ule(messageJSON.Username.ToString());
                    _database.MakeUserOnline(messageJSON.Username);


                    Sessions.SendTo(JsonConvert.SerializeObject(p),id);
                    _u("[SUCCESS] Authentication USER: " + messageJSON.Username);

                }

            }
            
        }

        ///<summary>
        /// This method sends a message to a specified client
        ///</summary>
        ///<param name="id">The id to send</param>
        ///<param name="d">The packet to send</param>
        ///string idOrigin, string idDestination, string message

        private void SendMessage(Packet p)
        {

            int chatid = p.GetChatID;
            //Packet temp = new Packet(Status.messageReceive);
            // temp.Message = message;
            // temp.OriginID = idOrigin;
            // temp.DestinationID = idDestination;

            // Sessions.SendTo(JsonConvert.SerializeObject(temp),idDestination);

            _database.AddMessageToChatRoom(chatid, p.Message);

            List<string> list = _database.GetUsersChat(chatid);

            Dictionary<int, KeyValuePair<List<string>, List<string>>> data = _database.GetChatRoomData(chatid);
            Packet temp = new Packet(Status.messageReceive);
            temp.GetStatus = Status.messageReceive;

            temp.ChatData = data;


            for(int i = 0; i < list.Count; i++)
            {
                string id = _database.GetID(list[i]);
                Sessions.SendTo(JsonConvert.SerializeObject(temp), id);



            }

            _u("[MESSAGE SENT] On chat room: "+chatid);






        }

        /// <summary>
        /// Makes a new chatroom
        /// </summary>
        /// <param name="p"></param>
        private void NewChatRoom(Packet p)
        {
            //Need to fix

            int i = _database.GetChatroomID;
            _database.MakeChatRoom(p.Username, p.DestinationUsername);

           
            
            Packet temp = new Packet(Status.chatroomSuccess);
            temp.ChatData = _database.GetChatRoomData(i);



            temp.GetStatus = Status.chatroomSuccess;
           
            Sessions.SendTo(JsonConvert.SerializeObject(temp), p.GetID);

            _u("[COMPLETED] Chatroom created for: " + p.Username);

         


            



        }


        private void ValidateOnline(Packet p)
        {
            _u("Chatroom Requested USER: " + p.GetID);
            if (_database.IsUserOnline(p.DestinationUsername))
            {
                NewChatRoom(p);
            }else
            {
                Packet temp = new Packet(Status.onlineFalse);

                temp.GetStatus = Status.onlineFalse;
                Sessions.SendTo(JsonConvert.SerializeObject(temp), p.GetID);
                _u("[FAILED] Chatroom Requested:: User offline USER: " + p.GetID);
            }


            _database.UpdateStatusOfAllUsers();
        }

        private void AddContact(Packet p)
        {

            Packet temp = new Packet(Status.addContact);
            temp.DestinationUsername = p.DestinationUsername;


            if (_database.AddContact(p.Username, p.DestinationUsername))
            {
                _database.AddContact(p.DestinationUsername, p.Username);
                temp.GetStatus = Status.contactAdded;
                Dictionary<string, bool> contacts = _database.GetContacts(p.Username);
                Dictionary<string, bool> contacts2 = _database.GetContacts(p.DestinationUsername);
                _u("[SUCCESS] Add Contact : " + p.DestinationUsername + " to USER: " + p.Username);

                Packet p2 = new Packet(Status.contactListSend);

                p2.ContactList = contacts2;

                Sessions.SendTo(JsonConvert.SerializeObject(p2), _database.GetID(p.DestinationUsername));



                temp.ContactList = contacts;
               

            }
            else
            {
                temp.GetStatus = Status.contactDenied;
                _u("[FAILED] Cannot Add Contact : " + p.DestinationUsername + " to USER: " + p.Username + " That user does not exsist...");



            }

            Sessions.SendTo(JsonConvert.SerializeObject(temp), p.GetID);
           

        }

        private void RemoveContact(Packet p)
        {
            string username = p.Username;
            string contactToRemove = p.DestinationUsername;

            _database.RemoveContact(username, contactToRemove);
            _database.RemoveContact(contactToRemove, username);

            Dictionary<string, bool> d1 = _database.GetContacts(username);
            Dictionary<string, bool> d2 = _database.GetContacts(contactToRemove);

            Packet origin = new Packet(Status.contactRemovedSuccess);
            Packet removedContact = new Packet(Status.contactListSend);

            origin.ContactList = d1;
            removedContact.ContactList = d2;

            Sessions.SendTo(JsonConvert.SerializeObject(origin), p.GetID);
            Sessions.SendTo(JsonConvert.SerializeObject(removedContact), _database.GetID(contactToRemove));

            _u("[SUCCESS] User: " + contactToRemove + " has been removed from contact list of: " + username);





        }

        public void SendContactList(Packet messageJSON)
        {
            _u("Contact List Request USER: " + messageJSON.Username);
            //Sends a message history from a specific client.
            Dictionary<string, bool> contacts = _database.GetContacts(messageJSON.Username);

            Packet p = new Packet(Status.contactListSend);
            p.ContactList = contacts;
            p.DestinationID = messageJSON.OriginID;
            p.OriginID = "server";

            Sessions.SendTo(JsonConvert.SerializeObject(p), messageJSON.GetID);


            _u("Contact List Request USER: " + messageJSON.Username + " [COMPLETED]");



        }

        private void LogoutSession(Packet p)
        {
            //string username = _database.GetUsername();
            _u("[LOGGING OUT IN PROGRESS] User:" + p.Username);
            _database.LogoutUser(p.Username);

            Dictionary<string, bool> d = _database.GetContacts(p.Username);

            foreach(string s in d.Keys)
            {
                Dictionary<string, bool> d1 = _database.GetContacts(s);

              
                Packet p1 = new Packet(Status.contactListSend);
                p1.ContactList = d1;

                Sessions.SendTo(JsonConvert.SerializeObject(p1), _database.GetID(s));


                

              



            }





            _u("[LOGOUT OK] User:" + p.Username);


        }

        
    
    }
}
