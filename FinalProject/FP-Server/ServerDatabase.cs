using FP_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FP_Server
{
    public class ServerDatabase
    {

        List<Observer> _registry = new List<Observer>();

        private Dictionary<string, User_m> _userDatabase;

        private List<ChatRoom> _chatRoom;

        private Dictionary<string, bool> _onLine;

        private Dictionary<int, KeyValuePair<List<string>, List<string>>> d;

        private Dictionary<string, string> _userPairing;





        private int count = 0;

        // private 







        public ServerDatabase()
        {

            _userDatabase = new Dictionary<string, User_m>();
            _onLine = new Dictionary<string, bool>();
            //AddPerson();
            ReadFromFile();
            //WriteToFile();
            _chatRoom = new List<ChatRoom>();
            _userPairing = new Dictionary<string, string>();
            d = new Dictionary<int, KeyValuePair<List<string>, List<string>>>();

        }


        public Dictionary<string, bool> GetOnline
        {
            get
            {
                return _onLine;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        private void AddPerson()
        {
            Dictionary<string, bool> a = new Dictionary<string, bool>();
            Dictionary<string, bool> m = new Dictionary<string, bool>();

            a.Add("mhixon", false);
            a.Add("Jason", false);
            a.Add("Steven", false);
            m.Add("sriegodedios", false);
            m.Add("Jason", false);
            m.Add("Steven", false);
            _userDatabase.Add("sriegodedios", new User_m("sriegodedios", "shaner26", a));
            _userDatabase.Add("mhixon", new User_m("mhixon", "matt555", m));
            _userDatabase.Add("Austin", new User_m("Austin", "stuff", a));
            _onLine.Add("sriegodedios", false);
            _onLine.Add("Jason", false);
            _onLine.Add("Steven", false);
            _onLine.Add("mhixon", false);
            _onLine.Add("Austin", false);

        }


        ///<summary>
        /// This method returns the contacts of the specfic username
        ///</summary>
        ///<param>string of a username that is used to find a user in the dictionary</param>
        public Dictionary<string, bool> GetContacts(string username)
        {
            if (_userDatabase.ContainsKey(username))
            {
                return _userDatabase[username].GetContacts;
            }

            return null;
           

        }

        ///<summary>
        /// This method removes a contact from a user's contact list
        ///</summary>
        ///<param>string of the username used to get the contact</param>
        ///<param>string of the contact name to be removed</param>
        public void RemoveContact(string username, string contact)
        {


            _userDatabase[username].RemoveContact(contact);


        }
        
        ///<summary>
        /// This method updates the status of all users weither they are
        /// offline or not.
        ///</summary>
        public void UpdateStatusOfAllUsers()
        {
            foreach (KeyValuePair<string, bool> kvp in _onLine)
            {
                string s = kvp.Key;
                bool on = kvp.Value;

                foreach (KeyValuePair<string, User_m> u in _userDatabase)
                {

                    if (u.Value.GetContacts.ContainsKey(s))
                    {
                        u.Value.GetContacts[s] = on;
                    }

                }






            }

        }

        ///<summary>
        /// This method adds a contact to the specific user.
        ///</summary>
        ///<param name="username">A strung of the username</param>
        ///<param name="contact">A string of the contact name</param>
        public bool AddContact(string username, string contact)
        {
            if (!_userDatabase.ContainsKey(contact))
            {
                return false;
            }

            _userDatabase[username].AddContact(contact, true);

            return true;




        }


        ///<summary>
        /// This method makes a specific user online by changing 
        /// the boolean of offline to true.
        ///</summary>
        ///<param name="username">A string of a username</param>
        public void MakeOnline(string username)
        {
            if(_onLine.ContainsKey(username))
            {
                // The first login of that specific user
                  _onLine.Add(username, true);
            }else
            {
                // After the first login of that user
                _onLine[username] = true;
            }
          
        }


        ///<summary>
        /// Logs in user by adding their name and id to a dictionary that
        /// pairs with each other.
        ///</summary>
        ///<param name="username">A string of the username</param>
        ///<param name="id">A string of the id of the user</param>
        public void LoginUser(string username, string id)
        {

            _userPairing.Add(username, id);
        }


        public void WriteToFile()
        {
            string jsonString = JsonConvert.SerializeObject(_userDatabase);

            using (StreamWriter sw = new StreamWriter("users.json"))
            {
                sw.Write(jsonString);
            }

            // Dictionary<string, User_m> m = JsonConvert.DeserializeObject<Dictionary<string, User_m>>(jsonString);

        }

        /// <summary>
        /// This method reads from the jsonfile and adds it to the database.
        /// </summary>
        private void ReadFromFile()
        {
            using (StreamReader file = new StreamReader("users.json"))
            {
                string jsonString = file.ReadToEnd();
                _userDatabase = JsonConvert.DeserializeObject<Dictionary<string, User_m>>(jsonString);

            }
        }

        /// <summary>
        /// This method adds the user to the database if the user makes a new account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddUser(string username, string password, string Id)
        {
            User_m user = new User_m(username, password, new Dictionary<string, bool>());
            user.GetID = Id;
            _userPairing.Add(username, Id);
            _userDatabase.Add(username, user);

        }




        /// <summary>
        /// Checks if the user exsist
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckUser(string username)
        {
            return _userDatabase.ContainsKey(username);
        }



        /// <summary>
        /// Checks if the password is correct
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool PasswordValidation(string username, string password)
        {
            string dbPassword = _userDatabase[username].Password;

            if (password == dbPassword)
            {
                return true;
            }

            return false;
        }

        public Dictionary<string, User_m> AllUsers
        {

            get
            {
                return _userDatabase;
            }

        }



        public string LookUpUserBaseOnID(string s)
        {

            foreach (KeyValuePair<string, User_m> KVP in _userDatabase)
            {

                if (s == KVP.Value.GetID)
                {
                    return KVP.Key;
                }


            }
            return null;



        }

        public void MakeUserOnline(string s)
        {
            if (_onLine.ContainsKey(s))
            {
                _onLine[s] = true;
            }
            else
            {
                _onLine.Add(s, true);
            }

            UpdateStatusOfAllUsers();

        }

        public void MakeUserOffline(string s)
        {
            _onLine[s] = false;

        }

        /// <summary>
        /// Checks to see if the user is online
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsUserOnline(string s)
        {
            return _onLine[s];
        }

        /// <summary>
        /// Create a new chatroom
        /// </summary>
        /// <param name="user"></param>
        /// <param name="destinationuser"></param>
        public void MakeChatRoom(string user, string destinationuser)
        {


            ChatRoom c = new ChatRoom(count);

            //Adds the users
            c.AddUser(user);
            c.AddUser(destinationuser);

            _chatRoom.Add(c);
            count++;

        }

        /// <summary>
        /// Adds a message to the chatroom
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        public void AddMessageToChatRoom(int id, string message)
        {
            _chatRoom[id].AddMessage(message);

        }


        /// <summary>
        /// Gets the message history of the chatroom
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> GetMessageHistory(int id)
        {
            return _chatRoom[id].MessageHistory;
        }

        public int GetChatroomID
        {
            get
            {
                return count;
            }

        }

        public List<string> GetUsersChat(int i)
        {
            return _chatRoom[i].GetUsers;
        }

        public Dictionary<int, KeyValuePair<List<string>, List<string>>> GetChatRoomData(int i)
        {
            //Dictionary<int, KeyValuePair<List<string>, List<string>>> d = new Dictionary<int, KeyValuePair<List<string>, List<string>>>();

            KeyValuePair<List<string>, List<string>> kvp = new KeyValuePair<List<string>, List<string>>(GetUsersChat(i), GetMessageHistory(i));
            if (d.ContainsKey(i))
            {

                d[i] = kvp;

            }
            else
            {
                d.Add(i, kvp);
            }


            return d;



        }

        public List<string> GetChatRoomUsers(int i)
        {
            return _chatRoom[i].GetUsers;
        }



        public int GetChatRoomUserCount(int id)
        {
            return _chatRoom[id].NumberOfUsers;
        }


        public string GetID(string username)
        {
            return _userPairing[username];
        }

        public List<ChatRoom> GetChatRoom
        {
            get
            {
                return _chatRoom;
            }
        }

        public string GetUsername(string id)
        {
            if (_userPairing.ContainsValue(id))
            {
                foreach (KeyValuePair<string, string> kvp in _userPairing)
                {
                    if (id == kvp.Value)
                    {
                        return kvp.Key;
                    }
                }
            }

            return null;
        }

        public void LogoutUser(string s)
        {

            _onLine[s] = false;
            UpdateStatusOfAllUsers();
            _userPairing.Remove(s);
            

        }

        public Dictionary<string, bool> GetUserContacts(string username)
        {
            if (_userDatabase.ContainsKey(username))
            {
                if (_userDatabase[username].GetContacts.ContainsKey(username))
                {
                    return _userDatabase[username].GetContacts;

                }


                //
            }


            return null;

        }



    }

}