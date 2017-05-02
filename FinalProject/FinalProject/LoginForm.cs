﻿using System;
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
        Message mh;
        //LoginObserver l;

        private string username;
        private string password;

        public LoginForm(InputHandler han, ClientModel m)
        {

            _handle = han;
            _model = m;


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

            if (password.Length == 0)
            {
                MessageBox.Show("Your password must be at least 1 character");
            }
            else
            {
                string[] arr = { username, password };
                _handle(this, arr);
            }

        }

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

