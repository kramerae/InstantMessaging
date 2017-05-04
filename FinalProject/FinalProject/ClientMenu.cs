using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// Client Menu Form
    /// </summary>
    public partial class ClientMenu : Form
    {
        private ClientModel _model;
        private InputHandler _handle;
        private int _selected;

        /// <summary>
        /// ClientMenu Constructor
        /// </summary>
        /// <param name="han">input handler</param>
        /// <param name="m">class model</param>
        public ClientMenu(InputHandler han, ClientModel m)
        {
            _model = m;
            _handle = han;
            InitializeComponent();
            uxRemoveContact.Enabled = false;
            uxStartChat.Enabled = false;
            uxAddContact.Enabled = false;
            uxAddChatMember.Enabled = false;          
        }

        /// <summary>
        /// Logout button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLogout_Click(object sender, EventArgs e)
        {
            // Call server to update status to offline
            string[] arr = { "OUT" };
            _handle(this, arr);

            // Close form
            Application.Exit();           
        }

        /// <summary>
        /// Remove contact button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemoveContact_Click(object sender, EventArgs e)
        {
            if(uxContactListBox.SelectedIndex != -1)
            {
                int index = uxContactListBox.SelectedIndex;
                string item = _model.ContactList.Keys.ElementAt(index);

      
                //string item = uxContactListBox.SelectedItem.ToString();

                const string message = "Are you sure that you would like to remove contact?";
                const string caption = "Remove Contact";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // server remove contact
                    string[] arr = { "RC", item };
                    _handle(this, arr);


                    // MessageBox.Show("Contact Removed!");
                }
            }
            else
            {
                MessageBox.Show("You must select a contact on the left.");
            }
            
        }

        /// <summary>
        /// Add contact button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddContact_Click(object sender, EventArgs e)
        {
            string name = uxAddNameText.Text;
            if (name.Count() > 0)
            {
                for (int i = 0; i < _model.ContactList.Count; i++)
                {
                    if(_model.ContactList.ContainsKey(name))
                    {
                        MessageBox.Show("Contact already exists in your list!");
                        break;
                    }
                }

                string[] arr = { "AC", name };
                _handle(this, arr);
            }
            else
            {
                MessageBox.Show("Must enter username to add!");
            }
        }

        /// <summary>
        /// start chat button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStartChat_Click(object sender, EventArgs e)
        {
            // Finds Username to start chat with
            string item = uxContactListBox.SelectedItem.ToString();
            char[] delimiterChars = { ' ', '|', '\t' };
            string[] words = item.Split(delimiterChars);

            if (words[0] != null)
            {
                // Input handler is called
                string[] arr = { "SC", words[0] };
                _handle(this, arr);
                MessageBox.Show("Creating Chat Room. ");
            }
            else
            {
                MessageBox.Show("Error. Please try again.");
            }
        }

        /// <summary>
        /// Calls handler to update the contact list on the form
        /// </summary>
        public void UpdateContactList()
        {
            string[] arr = {"UCL"};
            _handle(this, arr);
        }

        /// <summary>
        /// Functionality for selecting a contact from the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxRemoveContact.Enabled = true;
            uxStartChat.Enabled = true;
        }

        /// <summary>
        /// Refresh button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRefresh_Click(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        /// <summary>
        /// Updates the contact list box on the form
        /// </summary>
        public void UpdateContactListBox()
        {
            if(_model.AddContact == false)
            {
                MessageBox.Show("Contact does not exist!");
            }

            
            Dictionary<string, bool> contacts = _model.ContactList;
        
            uxContactListBox.EndUpdate();

            // Clear Items in List Box
            if (uxContactListBox.InvokeRequired)
            {

                Invoke(new MethodInvoker(delegate ()
                {

                    uxContactListBox.Items.Clear();
                }));
            }
            else
            {
                uxContactListBox.Items.Clear();
            }
            
            if(contacts != null)
            {
                // Add Contacts in List Box
                foreach (KeyValuePair<string, bool> s in contacts)
                {
                    if (uxContactListBox.InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate () {

                            if (s.Value == true)
                            {
                                uxContactListBox.Items.Add(string.Format("{0}  |  {1}", s.Key, "ONLINE"));

                            }
                            else
                            {
                                uxContactListBox.Items.Add(string.Format("{0}    {1}", s.Key, ""));
                            }

                        }));
                    }
                    else
                    {

                        if (s.Value == true)
                        {
                            uxContactListBox.Items.Add(string.Format("{0}  |  {1}", s.Key, "ONLINE"));

                        }
                        else
                        {
                            uxContactListBox.Items.Add(string.Format("{0}    {1}", s.Key, ""));
                        }
                    }
                }
            }

            uxContactListBox.EndUpdate();
        }

        /// <summary>
        /// Updates the chat room list box
        /// </summary>
        public void UpdateChatRoomListBox()
        {
            Dictionary<int, KeyValuePair<List<string>, List<string>>> chatrooms = _model.ChatRooms;

            uxChatroomsLB.EndUpdate();


            // Clear Items in List Box
            if (uxChatroomsLB.InvokeRequired)
            {

                Invoke(new MethodInvoker(delegate ()
                {

                    uxChatroomsLB.Items.Clear();
                }));
            }
            else
            {
                uxChatroomsLB.Items.Clear();
            }

            // Add chatroom # & users to listbox
            if (chatrooms != null)
            {
                foreach (KeyValuePair<int, KeyValuePair<List<string>, List<string>>> r in chatrooms)
                {
                    if (r.Value.Key.Contains(_model.Username))
                    {
                        if (uxChatroomsLB.InvokeRequired)
                        {
                            Invoke(new MethodInvoker(delegate () {

                                StringBuilder sb = new StringBuilder();
                                foreach (string name in r.Value.Key)
                                {
                                    sb.Append(name).Append(" | ");
                                }

                                uxChatroomsLB.Items.Add(r.Key.ToString() + ": " + sb.ToString());


                            }));
                        }
                        else
                        {
                            StringBuilder sb2 = new StringBuilder();
                            foreach (string name in r.Value.Key)
                            {
                                sb2.Append(name).Append(" | ");
                            }

                            uxChatroomsLB.Items.Add(sb2.ToString());
                        }
                    }

                   
                }
            }

            uxChatroomsLB.EndUpdate();
        }

        /// <summary>
        /// Updates the message list box
        /// </summary>
        public void UpdateMessageListBox()
        {
            Dictionary<int, KeyValuePair<List<string>, List<string>>> chatrooms = _model.ChatRooms;

            uxMessagesLB.EndUpdate();


            // Clear Items in List Box
            if (uxMessagesLB.InvokeRequired)
            {

                Invoke(new MethodInvoker(delegate ()
                {

                    uxMessagesLB.Items.Clear();
                }));
            }
            else
            {
                uxMessagesLB.Items.Clear();
            }


            // Add messages to message list box
            if (chatrooms != null)
            {
                if (uxMessagesLB.InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        int selected = uxChatroomsLB.SelectedIndex;


                        if (selected != -1)
                        {
                            // finds correct chatroom
                            string line = uxChatroomsLB.SelectedItem.ToString();

                            string[] things = line.Split(':');

                            int chatID = Convert.ToInt32(things[0]);

                            List<string> messages  = chatrooms[chatID].Value;
                            
                            // Adds messages to specific chatroom listbox
                            if (uxMessagesLB.InvokeRequired)
                            {
                                Invoke(new MethodInvoker(delegate ()
                                {

                                    for (int i = 0; i < messages.Count; i++)
                                    {
                                        uxMessagesLB.Items.Add(messages.ElementAt(i));
                                    }

                                }));
                            }
                            else
                            {
                                for (int i = 0; i < messages.Count; i++)
                                {
                                    uxMessagesLB.Items.Add(messages.ElementAt(i));
                                }
                            }
                        }
                        else
                        {
                            uxMessagesLB.Items.Add("You must select a chat room to see messages.");
                        }
                    }));
                }
                else
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        int selected = uxChatroomsLB.SelectedIndex;


                        if (selected != -1)
                        {
                            string line = uxChatroomsLB.SelectedItem.ToString();

                            string[] things = line.Split(':');

                            int chatID = Convert.ToInt32(things[0]);

                            List<string> messages = chatrooms[chatID].Value;

                            if (uxMessagesLB.InvokeRequired)
                            {
                                Invoke(new MethodInvoker(delegate ()
                                {

                                    for (int i = 0; i < messages.Count; i++)
                                    {
                                        uxMessagesLB.Items.Add(messages.ElementAt(i));
                                    }

                                }));
                            }
                            else
                            {
                                for (int i = 0; i < messages.Count; i++)
                                {
                                    uxMessagesLB.Items.Add(messages.ElementAt(i));
                                }
                            }
                        }
                        else
                        {
                            uxMessagesLB.Items.Add("You must select a chat room to see messages.");
                        }
                    }));
                }


            }
            uxChatroomsLB.EndUpdate();
        }

        /// <summary>
        /// Event handler for selecting chat room from list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxChatroomsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates Message list box depending on selected chatroom
            _selected = uxChatroomsLB.SelectedIndex;
            uxAddChatMember.Enabled = true;
            UpdateMessageListBox();
        }

        // Unused
        private void uxMessagesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Unused
        private void uxText_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Event handler for hitting the send button on the chat view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSend_Click(object sender, EventArgs e)
        {
            // Gets text to send
            string txt = uxText.Text;
            string message = _model.Username + ": " + txt;

            
            int selected = uxChatroomsLB.SelectedIndex;
            if(selected == -1)
            {
                MessageBox.Show("You must select a chat on the left.");
            }
            else
            {
                // Gets chatroom
                string line = uxChatroomsLB.SelectedItem.ToString();

                string[] things = line.Split(':');

                int chatID = Convert.ToInt32(things[0]);

                string[] arr = { "IM", chatID.ToString(), message };

                // Calls handler
                _handle(this, arr);

                uxText.Text = "";
            }
            
        }

        /// <summary>
        /// Event handler for loading the form
        /// Loads the contact list upon loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMenu_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        /// <summary>
        /// Event handler for typing in add contact textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddNameText_TextChanged(object sender, EventArgs e)
        {
            // Enables button to add contact
            uxAddContact.Enabled = true;
        }

        /// <summary>
        /// Event handler for adding contact to chatroom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddChatMember_Click(object sender, EventArgs e)
        {
            if(uxContactListBox.SelectedIndex != -1)
            {
                // Get current chat room
                string line = uxChatroomsLB.SelectedItem.ToString();

                string[] things = line.Split(':');

                int chatID = Convert.ToInt32(things[0]);

                // Finds user selected to add
                int selectedUser = uxContactListBox.SelectedIndex;
                string username = _model.ContactList.Keys.ElementAt(selectedUser);

                // Calls input handler
                string[] arr = { "NU", chatID.ToString(), username };
                _handle(this, arr);
            }
            else
            {
                MessageBox.Show("You must select a contact from your contact list to add to the chat.");
            }
        }
    }
}
