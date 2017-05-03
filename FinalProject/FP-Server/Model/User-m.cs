﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FP_Server.Model
{
    [JsonObject]
    public class User_m
    {
        private string _user;
        private string _password;
        private Dictionary<string, bool> _contacts;
        private bool _isOnline;
        private string _id;
       // private _currentW


        public User_m(string user, string password, Dictionary<string, bool> contacts)
        {
            _contacts = new Dictionary<string, bool>();
            //_contacts 
            //_id = id;
            _user = user;
            _password = password;
            _contacts = contacts;
        }

        public string User
        {
            get
            {
                return _user;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
        }

        public void AddContact(string name, bool isOnline)
        {
            _contacts.Add(name, isOnline);
        }


        public void RemoveContact(string name)
        {
            _contacts.Remove(name);

        }

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
