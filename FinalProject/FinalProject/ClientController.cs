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
        ClientModel _m;
        private string userName;
        private WebSocket ws;
        private Dictionary<string, bool> contacts;
        private string _id;

        public event Message MessageEvent;

        public ClientController()
        {
           // _m = m;

            contacts = new Dictionary<string, bool>();
            contacts.Add("Bob", true);
            contacts.Add("Sally", false);
            contacts.Add("Austin", true);

            

            // Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8550/chat");
            ws.OnMessage += (sender, e) => { if (MessageEvent != null) MessageReceived(e.Data); };
            ws.Connect();


        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value; 
            }
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
                case Status.loginTrue:
                    //MessageBox.Show("Works: Login Successful");
                    break;
                case Status.loginFalse:
                   //MessageBox.Show("Login Invalid: Wrong Password");
                    break;
                case Status.connectionSuccess:
                    _id = p.GetID;
                    break;

            }

            return true; 
        }
        
        // Handles when a new message is entered by the user
        public bool MessageEntered(string message)
        {
            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(userName + ": " + message);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
