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

        public ClientMenu(ClientController c)
        {
            _c = c;
            InitializeComponent();
            uxRemoveContact.Enabled = false;
            uxStartChat.Enabled = false;
            UpdateContactList();

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
                MessageBox.Show("Contact Removed!");
                // update contact list 
            }
        }

        private void uxAddContact_Click(object sender, EventArgs e)
        {
            using (AddContactForm ac = new AddContactForm())
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
            Dictionary<string, bool> contacts = _c.GetContacts;

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
        }

        private void uxContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxRemoveContact.Enabled = true;
            uxStartChat.Enabled = true;
        }

        private void uxRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
