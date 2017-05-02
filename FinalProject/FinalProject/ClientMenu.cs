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
    public partial class ClientMenu : Form
    {
        private ClientController _c;
        private ClientModel _model;
        private InputHandler _handle;


        public ClientMenu(InputHandler han, ClientModel m)
        {
            _model = m;
            _handle = han;
            InitializeComponent();
            uxRemoveContact.Enabled = false;
            uxStartChat.Enabled = false;
            //UpdateContactList();
        }

        private void uxLogout_Click(object sender, EventArgs e)
        {
            // Call server to update status to offline
            // Close form
            
        }

        private void uxRemoveContact_Click(object sender, EventArgs e)
        {
            // Update contact list in server
            // Update Model
            // Update ListBox
            const string message = "Are you sure that you would like to remove the contact?";
            const string caption = "Remove Contact";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                // server remove contact
                

                // update contact list 
                UpdateContactList();

                MessageBox.Show("Contact Removed!");
            }
        }

        private void uxAddContact_Click(object sender, EventArgs e)
        {
            using (AddContactForm ac = new AddContactForm(_handle, _model))
            {
                if (ac.ShowDialog() == DialogResult.OK)
                {
                    // ???????
                }
            }
            // Check to see if user exists in server
            // If so add to contact list in server
            // Update ListBox
        }

        private void uxStartChat_Click(object sender, EventArgs e)
        {
            
            // Check to see if online
            // Lauch chat form
            
            using (Chat ch = new Chat(_c.MessageEntered))
            {
                //_c.MessageReceived += ch.MessageReceived;
                if (ch.ShowDialog() == DialogResult.OK)
                {
                   
                    // ???????
                }
            }
            
        }

        public void UpdateContactList()
        {
            string[] arr = {"UCL"};
            _handle(this, arr);

            /*
           // Task.Delay(10000);
           //Update
            Dictionary<string, bool> contacts = _model.ContactList;

            
            
            while (_model.Update == false)
            {
                Task.Delay(1000);
            }
            

            foreach (string s in contacts.Keys)
            {
                if(contacts[s] == true)
                {
                    uxContactListBox.Items.Add(string.Format("{0}  |  {1}", s, "ONLINE"));
       
                }
                else
                {
                    uxContactListBox.Items.Add(string.Format("{0}    {1}", s, ""));
                }
            }
            */
        }

        private void uxContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxRemoveContact.Enabled = true;
            uxStartChat.Enabled = true;
        }

        private void uxRefresh_Click(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        public void UpdateListBox()
        {
            Dictionary<string, bool> contacts = _model.ContactList;
            
            foreach (string s in contacts.Keys)
            {
                if (contacts[s] == true)
                {
                    uxContactListBox.Items.Add(string.Format("{0}  |  {1}", s, "ONLINE"));

                }
                else
                {
                    uxContactListBox.Items.Add(string.Format("{0}    {1}", s, ""));
                }
            }
        }
    }
}
