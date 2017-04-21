using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;


namespace FinalProject
{
    public class ClientController
    {
        ClientModel _m;
        private string userName;
        private WebSocket ws;
        private Dictionary<string, bool> contacts;


        public ClientController()
        {
           // _m = m;

            contacts = new Dictionary<string, bool>();
            contacts.Add("Bob", true);
            contacts.Add("Sally", false);
            contacts.Add("Austin", true);
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



        
        /*
        // Handles when a new message is entered by the user
        public bool MessageEntered(string message)
        {

        }
        */
    }
}
