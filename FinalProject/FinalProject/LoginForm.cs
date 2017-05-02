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
    /// Form to validate credentials and log into application
    /// </summary>
    public partial class LoginForm : Form
    {

        private ClientModel _model;
        private InputHandler _handle;
        Message mh;
        //LoginObserver l;

        private string username;
        private string password;

        /// <summary>
        /// Constructor for LoginForm
        /// </summary>
        /// <param name="han">Input handler</param>
        /// <param name="m">Model</param>
        public LoginForm(InputHandler han, ClientModel m)
        {
            _handle = han;
            _model = m;
            
            InitializeComponent();

            button1.Enabled = false;
            textBox2.Enabled = false;
        }

        /// <summary>
        /// Getter/Setter for Username
        /// </summary>
        public string GetUsername
        {
            get
            {
                return username;
            }
        }

        /// <summary>
        /// Event handler for login button
        /// </summary>
        /// <param name="sender">button as object</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Get info from form
            username = textBox1.Text;
            password = textBox2.Text;

            // Validate password length
            if (password.Length == 0)
            {
                MessageBox.Show("Your password must be at least 1 character");
            }
            else
            {
                // Use handler to verify credentials
                string[] arr = { username, password };
                _handle(this, arr);
            }

        }

        /// <summary>
        /// Method to update form on observer register
        /// </summary>
        public void LoginUpdate()
        {
            bool login = _model.LoginStatus;

            if (login == false)
            {
                MessageBox.Show("Invalid username or password.");
            }
            else
            {
                Invoke(new Action(() => this.DialogResult = DialogResult.OK));
            }
        }

        /// <summary>
        /// Enable password field once username has been entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        /// <summary>
        /// Enable login button once password has been entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

    }
}

