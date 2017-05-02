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
           
            // Check to see if user exists in server
            // If so add to contact list in server
            // Update ListBox
        }

        private void uxStartChat_Click(object sender, EventArgs e)
        {
            
            string item = uxContactListBox.SelectedItem.ToString();
            char[] delimiterChars = { ' ', '|', '\t' };
            string[] words = item.Split(delimiterChars);

            if (words[0] != null)
            {
                string[] arr = { "SC", words[0] };
                _handle(this, arr);
            }
            else
            {
                MessageBox.Show("Error. Please try again.");
            }
        }
        

        public void UpdateContactList()
        {
            string[] arr = {"UCL"};
            _handle(this, arr);
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

        public void UpdateContactListBox()
        {
            Dictionary<string, bool> contacts = _model.ContactList;
        
            uxContactListBox.EndUpdate();
            
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

            uxContactListBox.EndUpdate();
        }

        private void uxChatroomsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxMessagesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxSend_Click(object sender, EventArgs e)
        {

        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }
    }
}
