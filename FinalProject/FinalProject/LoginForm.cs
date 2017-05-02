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
    public partial class LoginForm : Form
    {
        private ClientModel _model;
        private InputHandler _handle;
        private ClientMenu cm;
        Message mh;
        LoginObserver l;

        private string username;
        private string password;

        public LoginForm(InputHandler han, ClientModel m, ClientMenu menu)
        {

            _handle = han;
            _model = m;


            cm = menu;


            //mh = newMessageHandler;
            InitializeComponent();

            button1.Enabled = false;
            textBox2.Enabled = false;
        }

        public string GetUsername
        {
            get
            {
                return username;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            username = textBox1.Text;
            password = textBox2.Text;

            if(password.Length == 0)
            {
                MessageBox.Show("Your password must be at least 1 character");
            }
            else
            {
                string[] arr = { username, password};
                _handle(this, arr);
                
                // bool login = l();
                //bool login = _c.LoginValidate(username, password);
               
                
                //Task.Delay(2000);
                
                bool login = _model.LoginStatus;
                
                if (login == false)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    // test
                    // Set username in controller

                    //_c.UserName = username;



                    /*
                     * WORKS WITHOUT OBSERVER
                    using (ClientMenu cm = new ClientMenu(_handle, _model))
                    {
                        if (cm.ShowDialog() == DialogResult.OK)
                        {
                            // ???????
                           
                        }
                    }
                    */

                    if (cm.ShowDialog() == DialogResult.OK)
                    {
                        // ???????

                    }
                }
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        
    }
}
