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

namespace FP_Server
{
    public partial class ServerForm : Form
    {
        
        WebSocketServer ws;
        ServerDatabase sd;
        
        //rverController _sc;
        public ServerForm(WebSocketServer w, ServerDatabase s)
        {
            ws = w;
            sd = s;
            InitializeComponent();

        }

        private void uxBtnStartServer_Click(object sender, EventArgs e)
        {
           
            Updates("Starting Server...");
            uxBtnStartServer.Enabled = false;
            uxBtnStopServer.Enabled = true;
            ws.Start();
            Updates("Server has started at port: 8550");
        }

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



        private void UpdateUserListBox(string s)
        {
            ListViewItem s1 = new ListViewItem(s + " | Online");

            s1.SubItems.Add("s");
            // s1.SubItems.Add("Online");

            uxListViewUsers.EndUpdate();

            if (uxListViewUsers.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () { uxListViewUsers.Items.Add(s1); }));
            }
            else
            {
                uxListViewUsers.Items.Add(s1);
            }



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


        public void UpdateContacts()
        {
           // Dictionary<string,bool> dtemp = 




        }

        public void LogoutUser(string s)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uxButtonClearServerLog_Click(object sender, EventArgs e)
        {
            uxEventListBox.Items.Clear(); 

        }
    }
}
