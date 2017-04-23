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
        private ClientController _c;
        private string username;
        private string password;

  

        public LoginForm(ClientController c)
        {
            _c = c;
            InitializeComponent();

            button1.Enabled = false;
            textBox2.Enabled = false;
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
                bool login = _c.LoginValidate(username, password);

                if (login == false)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    using (ClientMenu cm = new ClientMenu(_c))
                    {
                        if (cm.ShowDialog() == DialogResult.OK)
                        {
                            // ???????
                           
                        }
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
