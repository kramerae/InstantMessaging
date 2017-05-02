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
        //private string userName;
        private WebSocket ws;
        private Dictionary<string, bool> contacts;
        //private string _id;

        public delegate void Observer();

        private List<Observer> observers = new List<Observer>();

        // private List<LoginObserver> observersLogin = new List<LoginObserver>();
        //private List<MenuObserver> observersMenu = new List<MenuObserver>();
        private bool loginStatus = false;

        //UpdateContactList del1 = new UpdateContactList(); 

        public event Message MessageEvent;

        public ClientController(ClientModel m)
        {
            _model = m;

            contacts = new Dictionary<string, bool>();
            contacts.Add("Bob", true);
            contacts.Add("Sally", false);
            contacts.Add("Austin", true);



            // Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8550/chat");
            ws.OnMessage += (sender, e) => { if (MessageEvent != null) MessageReceived(e.Data); };
            ws.Connect();


        }


        // REMOVE LATER
        public Dictionary<string, bool> GetContacts
        {
            get
            {
                return contacts;
            }
        }

        public bool LoginValidate(string name, string password)
        {
            bool validate;
            // Call server to see if username and password match
            // If new username creates a new account

            // If validate is true store name in username
            // Return bool result
            return true;
        }



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
                    break;
                case Status.chatroomSuccess:

                    updateForms();
                    break;
                case Status.onlineFalse:

                    updateForms();
                    break;
            }

            

            return true;
        }

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

            ws.WaitTime = TimeSpan.FromSeconds(2);
        }


        // Handles when a new message is entered by the user
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

                }
                // Add contact
                else if (items[0] == "AC")
                {

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

            }
            else if (sender.GetType() == typeof(FinalProject.AddContactForm))
            {
                string add = items[1];
                // FINISH
            }



        }

        public void register(Observer f)
        {
            observers.Add(f);
        }


        public void updateForms()
        {
            foreach (Observer m in observers)
            {
                m();
            }
        }

        public void clearObservers()
        {
            observers = new List<Observer>();
        }
    }
}

