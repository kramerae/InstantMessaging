using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using ClassLibrary;
using Newtonsoft.Json;

namespace FinalProject
{
    public class ClientController
    {
        ClientModel _model;
        private WebSocket ws;

        public delegate void Observer();

        private List<Observer> observers = new List<Observer>();


        public event Message MessageEvent;

        public ClientController(ClientModel m)
        {
            _model = m;

            // Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8550/chat");
            ws.OnMessage += (sender, e) => { if (MessageEvent != null) MessageReceived(e.Data); };
            ws.Connect();


        }
        
        /// <summary>
        /// Receives and deserializes the Json string and constructs a package object to be used
        /// </summary>
        /// <param name="message">Json string sent in to be deserialized</param>
        /// <returns></returns>
        public bool MessageReceived(string message)
        {
            // Deseralize Packet 
            Packet p = JsonConvert.DeserializeObject<Packet>(message);

            switch (p.GetStatus)
            {
                case Status.connectionSuccess:
                    _model.ID = p.GetID; 
                    break;
                case Status.loginFalse:
                    _model.LoginStatus = false;
                    updateForms();
                    //MessageBox.Show("Login Invalid: Wrong Password");
                    break;
                case Status.loginTrue:
                    _model.LoginStatus = true;
                    _model.Username = p.Username;
                    updateForms();
                    //MessageBox.Show("Works: Login Successful");
                    clearObservers();
                    break;
                case Status.contactListSend:
                    _model.ContactList = p.ContactList;
                    updateForms();
                    //clearObservers();
                    break;
                case Status.chatroomSuccess:
                    _model.ChatRooms = p.ChatData;
                    updateForms();
                    //clearObservers();
                    break;
                case Status.onlineFalse:

                    updateForms();
                    break;
                case Status.messageReceive:
                    _model.ChatRooms = p.ChatData;
                    updateForms();
                    break;
                case Status.contactAdded:
                    _model.ContactList = p.ContactList;
                    updateForms();
                    break;
                case Status.contactDenied:
                    _model.AddContact = false;
                    updateForms();
                    _model.AddContact = true;
                    break;
                case Status.contactRemovedSuccess:
                    _model.ContactList = p.ContactList;
                    updateForms();
                    break;

                case Status.addContactChatSuccess:
                    _model.ChatRooms = p.ChatData;
                    break;
            }

            

            return true;
        }

        /// <summary>
        /// Serializes and sends packet to server for processing
        /// </summary>
        /// <param name="p">Packet to be sent</param>
        /// <returns></returns>
        public bool MessageEntered(Packet p)
        {

            //p.GetStatus = Status.loginValidate;
            // Generate Packet
            string send = JsonConvert.SerializeObject(p);

            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(send);
                return true;
            }
            else
            {
                return false;
            }
            
        }


        //DELETE LATER

        /// <summary>
        /// Handles when a new message is entered by the user
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool MessageEntered(string message)
        {
            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(_model.Username + ": " + message);
                return true;
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// Method to handle input to create and pass packets to be sent to server
        /// </summary>
        /// <param name="sender">object sending info</param>
        /// <param name="items">items array being parsed for info</param>
        public void handle(object sender, string[] items)
        {
            if (sender.GetType() == typeof(FinalProject.LoginForm))
            {
                string u = items[0];
                string p = items[1];
                Packet p1 = new Packet(Status.loginValidate);
                p1.Username = u;
                p1.Password = p;
                p1.GetID = _model.ID;
                MessageEntered(p1);
            }
            else if (sender.GetType() == typeof(FinalProject.ClientMenu))
            {
                // Update contact list
                if (items[0] == "UCL")
                {
                    Packet p2 = new ClassLibrary.Packet(Status.contactListRequest);
                    p2.Username = _model.Username;
                    p2.GetID = _model.ID;
                    MessageEntered(p2);
                }
                // Remove contact
                else if (items[0] == "RC")
                {
                    Packet p3 = new ClassLibrary.Packet(Status.removeContactRequest);
                    p3.Username = _model.Username;
                    p3.GetID = _model.ID;
                    p3.DestinationUsername = items[1];
                    MessageEntered(p3);
                }
                // Add contact
                else if (items[0] == "AC")
                {
                    Packet p4 = new ClassLibrary.Packet(Status.addContact);
                    p4.Username = _model.Username;
                    p4.GetID = _model.ID;
                    p4.DestinationUsername = items[1];
                    MessageEntered(p4);
                }
                // Start Chat
                else if (items[0] == "SC")
                {
                    Packet p5 = new ClassLibrary.Packet(Status.requestChatRoom);
                    p5.Username = _model.Username;
                    p5.GetID = _model.ID;
                    p5.DestinationUsername = items[1];
                    MessageEntered(p5);
                }
                else if (items[0] == "IM")
                {
                    Packet p6 = new ClassLibrary.Packet(Status.messageSend);
                    p6.Username = _model.Username;
                    p6.GetID = _model.ID;
                    p6.GetChatID = Convert.ToInt32(items[1]);
                    p6.Message = items[2];
                    MessageEntered(p6);
                }
                else if(items[0] == "NU")
                {
                    Packet p7 = new ClassLibrary.Packet(Status.addContactChatRequest);
                    p7.Username = _model.Username;
                    p7.GetID = _model.ID;
                    p7.GetChatID = Convert.ToInt32(items[1]);
                    p7.DestinationUsername = items[2];
                }
                else if(items[0] == "OUT")
                {
                    Packet p8 = new ClassLibrary.Packet(Status.logout);
                    p8.Username = _model.Username;
                    p8.GetID = _model.ID;
                    MessageEntered(p8);
                }

            }


        }

        /// <summary>
        /// register observer
        /// </summary>
        /// <param name="f">observer being updated</param>
        public void register(Observer f)
        {
            observers.Add(f);
        }

        /// <summary>
        /// Updates forms in the view
        /// </summary>
        public void updateForms()
        {
            foreach (Observer m in observers)
            {
                m();
            }
        }

        /// <summary>
        /// clears observer content
        /// </summary>
        public void clearObservers()
        {
            observers = new List<Observer>();
        }
    }
}

