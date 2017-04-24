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
                case Status.LoginRequest:
                    {
                        if (!_database.CheckUser(messageJSON.Username))
                        {
                            //User does not exsist

                            _database.AddUser(messageJSON.Username, messageJSON.Password);

                            // Logins the user
                            Sessions.Broadcast(JsonConvert.SerializeObject(new Delivery(Status.LoginSuccess)));


                        }else
                        {
                            //User exsists

                            if(!_database.PasswordValidation(messageJSON.Username, messageJSON.Password))
                            {
                                //Password is incorrect
                                Sessions.Broadcast(JsonConvert.SerializeObject(new Delivery(Status.LoginFailed)));

                            }else
                            {
                                //Password is correct
                                Sessions.Broadcast(JsonConvert.SerializeObject(new Delivery(Status.LoginSuccess)));
                            }

                        }
                        break;
                    }
                case Status.SendMessage:
                    {

                        Sessions.Broadcast()


                        break;
                    }
                    

                   
               
                    
                
                    
                    



            }














        }
        
        public ServerController()
        {
            _database = new ServerDatabase();
            _chatRoom = new List<int>();
        }
    }
}
