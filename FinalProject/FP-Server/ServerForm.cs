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

        public void UpdateUserLists(Dictionary<string,bool> d)
        {
            UpdateUserListBox(d);

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
            //ListViewItem s1 = new ListViewItem(s + " | Online");
            string p = s + " | Online";
            //s1.SubItems.Add("s");
            //s1.SubItems.Add("Online");

            if (uxListBoxUserNames.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () { uxListBoxUserNames.Items.Add(p); }));


            }else
            {
                uxListBoxUserNames.Items.Add(p);
            }

              
            uxListBoxUserNames.EndUpdate();



            /*for(int i = 0; i < uxListViewUsers.Items.Count; i++)
            {
                if(s == (string)uxListViewUsers.Items[i].Name)
              {
                    checkedListBoxUsers.CheckedItems[i] = true;
                    break;
                }

            }*/

            uxListBoxContacts.EndUpdate();
        }

        private void UpdateUserListBox(Dictionary<string, bool> d)
        {
            //ListViewItem s1 = new ListViewItem(s + " | Online");
            // string p = s + " | Online";
            //s1.SubItems.Add("s");
            //s1.SubItems.Add("Online");
            if (uxListBoxUserNames.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    uxListBoxUserNames.Items.Clear();


                }));
            }
            else
            {
                uxListBoxUserNames.Items.Clear();
            }

                
            uxListBoxUserNames.EndUpdate();
            foreach(KeyValuePair<string, bool> kvp in d)
            {
                string s = kvp.Key;
                if (uxListBoxUserNames.InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        if (kvp.Value == true)
                        {

                            s += (" | Online");


                        }
                        else
                        {
                            s += (" | Offline");
                        }

                        uxListBoxUserNames.Items.Add(s);
                    }));
                }else
                {
                    if (kvp.Value == true)
                    {

                        s += (" | Online");


                    }
                    else
                    {
                        s += (" | Offline");
                    }

                    uxListBoxUserNames.Items.Add(s);


                }


            }



           /* if (uxListBoxUserNames.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {

                    



                    uxListBoxUserNames.Items.Add(p);


                }));


            }
            else
            {
                uxListBoxUserNames.Items.Add(p);
            }


            uxListBoxUserNames.EndUpdate();*/



            /*for(int i = 0; i < uxListViewUsers.Items.Count; i++)
            {
                if(s == (string)uxListViewUsers.Items[i].Name)
              {
                    checkedListBoxUsers.CheckedItems[i] = true;
                    break;
                }

            }*/

            uxListBoxContacts.EndUpdate();
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

        private void uxListBoxUserNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = uxListBoxUserNames.SelectedIndex;
            string item = (string)uxListBoxUserNames.Items[selected];

            string[] items = item.Split(' ');

            Dictionary<string, bool> d = sd.GetContacts(items[0]);

            uxListBoxContacts.EndUpdate();

            foreach(string name in d.Keys)
            {

                uxListBoxContacts.Items.Add(name);

            }
            uxListBoxContacts.EndUpdate();

        }

     
    }
}
