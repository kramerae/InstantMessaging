using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Threading;
using FP_Server.Model;
using System.IO;

namespace FP_Server
{

    public partial class ServerForm : Form
    {
        
        WebSocketServer ws;
        private ServerDatabase sd;
        
        //rverController _sc;

        //ServerForm constructor
        public ServerForm(WebSocketServer w, ServerDatabase s)
        {
            ws = w;
            sd = s;
            InitializeComponent();
        }

        //Starts the server when the button is clicked
        private void uxBtnStartServer_Click(object sender, EventArgs e)
        {          
            Updates("Starting Server...");
            uxBtnStartServer.Enabled = false;
            uxBtnStopServer.Enabled = true;
            ws.Start();
            Updates("Server has started at port: 8550");
        }

        //Stops the server when the button is clicked
        private void uxBtnStopServer_Click(object sender, EventArgs e)
        {
            Updates("Server Has Stopped...");
            ws.Stop();
            uxBtnStopServer.Enabled = false;
            uxBtnStartServer.Enabled = true;
        }

        public void UpdateListEvents(string events)
        {
            Updates(events);
        }

        public void UpdateUserLists(string s)
        {
            UpdateUserListBox(s);

        }


        private void Updates(string s)
        {
            string log = "["+DateTime.Now+"]" + ":: " + s;
               uxEventListBox.EndUpdate();
            if(uxEventListBox.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () { uxEventListBox.Items.Add(log); }));
            }
            else
               uxEventListBox.Items.Add(log);
               uxEventListBox.EndUpdate();        
           
           // MessageBox.Show(events);
        }


        //Updates the list box of the users
        private void UpdateUserListBox(string s)
        {
            ListViewItem s1 = new ListViewItem(s + " | Online");

            s1.SubItems.Add("s");
            // s1.SubItems.Add("Online");

            uxListViewUsers.EndUpdate();

            //for(int i = 0; i < checkedListBoxUsers.Items.Count; i++)
            //{
            //    if(s == (string)checkedListBoxUsers.Items[i])
            //    {
            //        checkedListBoxUsers.CheckedItems[i] = true;
            //        break;
            //    }

            //}

            //checkedListBoxUsers.EndUpdate();
        }

        //Updates the Contacts
        public void UpdateContacts()
        {
           // Dictionary<string,bool> dtemp = 

        }

        //Logs out user
        public void LogoutUser(string s)
        {

        }

        //Gives color
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Clears the server log
        private void uxButtonClearServerLog_Click(object sender, EventArgs e)
        {
            uxEventListBox.Items.Clear(); 
        }

        //Method for when the Save Log button is clicked
        private void uxSaveLogBtn_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("log.txt"))
            {
                foreach(string s in uxEventListBox.Items)
                {
                    sw.WriteLine(s);
                }
                MessageBox.Show("Log written successfully");
            }
        }


        //Writes the log and users when the form closes
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {         
            using (StreamWriter sw = new StreamWriter("log.txt"))
            {
                foreach (string s in uxEventListBox.Items)
                {
                    sw.WriteLine(s);
                }
                MessageBox.Show("Log written successfully");
            }
            sd.WriteToFile();
            Application.ExitThread();
        }
    }
}
