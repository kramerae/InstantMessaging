﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using ClassLibrary;

using Newtonsoft.Json;

namespace FinalProject
{
    public class ClientController { 
        ClientModel _model;
        //private string userName;
        private WebSocket ws;
        private Dictionary<string, bool> contacts;
        //private string _id;
        private List<Observer> observers = new List<Observer>();
        private bool loginStatus = false; 


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
                    //MessageBox.Show("Login Invalid: Wrong Password");
                    break;
                case Status.loginTrue:
                    _model.LoginStatus = true;
                    _model.Username = p.Username;
                    //MessageBox.Show("Works: Login Successful");
                    break;
                case Status.contactListSend:
                    _model.ContactList = p.ContactList;
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
                if (items[0] == "UCL")
                {
                    Packet p2 = new ClassLibrary.Packet(Status.contactListRequest);
                    p2.Username = _model.Username;
                    p2.GetID = _model.ID;
                    MessageEntered(p2);
                }
                if (items[0] == "RC")
                {

                }
                
            }
            else if(sender.GetType() == typeof(FinalProject.AddContactForm))
            {
                string add = items[1];
                // FINISH
            }


            
        }


        public bool registerLogin()
        {
            return loginStatus;
        }

        // register(f) adds event-handler method  f  to the registry:
        public void register(Observer f) { observers.Add(f); }
    }
}
