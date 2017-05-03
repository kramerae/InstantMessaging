using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FP_Server.Model
{
    //User_m class
    [JsonObject]
    public class User_m
    {
        private string _user;
        private string _password;
        private Dictionary<string, bool> _contacts;
        private bool _isOnline;
        private string _id;
       // private _currentW

        //constructor for the User_m
        public User_m(string user, string password, Dictionary<string, bool> contacts)
        {
            _contacts = new Dictionary<string, bool>();
            //_contacts 
            //_id = id;
            _user = user;
            _password = password;
            _contacts = contacts;
        }

        //Returns the user name
        public string User
        {
            get
            {
                return _user;
            }
        }

        //returns the password
        public string Password
        {
            get
            {
                return _password;
            }
        }

        //adds a contact to the user's contact list
        public void AddContact(string name, bool isOnline)
        {
            _contacts.Add(name, isOnline);
        }

        //removes the contact from user's contact list
        public void RemoveContact(string name)
        {
            _contacts.Remove(name);

        }

        //returns the dictionary of the user's contacts
        public Dictionary<string, bool> GetContacts
        {
            get
            {
                return _contacts;
            }set
            {
                _contacts = value;
            }
        }

        //returns true/false if online. also sets value of _isOnline
        public bool IsOnline
        {
            get
            {
                return _isOnline;
            }set
            {
                _isOnline = value;
            }
        }

        //gets/sets the user id
        public string GetID
        {
            get
            {
                return _id;

            }set{

                _id = value;
            }
        }

    }
}
