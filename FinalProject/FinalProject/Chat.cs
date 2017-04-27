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
    public partial class Chat : Form
    {
        Message mh;

        public Chat(Message newMessageHandler)
        {
            InitializeComponent();
            mh = newMessageHandler;

            ChatTextBox.KeyDown += (o, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    string message = ChatTextBox.Text;
                    if (mh(message))
                    {
                        ChatTextBox.Text = "";
                    }
                }
            };

            // Make sure to focus on messageTextBox when the form is loaded
            ChatTextBox.Select();
        }

        private void uxSend_Click(object sender, EventArgs e)
        {
           // ChatTextBox.KeyDown += (o, ev) =>
          //  {
                //if (ev.KeyCode == Keys.Enter)
               // {

                    
                    string message = ChatTextBox.Text;
                    if (mh(message))
                    {
                        ChatTextBox.Text = "";
                    }
               // }
           // };

            // Make sure to focus on messageTextBox when the form is loaded
            ChatTextBox.Select();
        }

        public bool MessageReceived(string message)
        {
            // Add message to messageListBox and scroll to bottom
            // Invoke is used to make sure that this is done in the GUI thread
            Invoke(new Action(() => MessageBox.TopIndex = MessageBox.Items.Add(message)));

            return true;
        }

    }
}
