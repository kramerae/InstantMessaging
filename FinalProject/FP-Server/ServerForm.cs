﻿using System;
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

namespace FP_Server
{
    public partial class ServerForm : Form
    {
        WebSocketServer ws;
        //rverController _sc;
        public ServerForm(WebSocketServer w)
        {
            ws = w;
            InitializeComponent();

        }

        private void uxBtnStartServer_Click(object sender, EventArgs e)
        {
            ws.Start();
            uxBtnStartServer.Enabled = false;
            uxBtnStopServer.Enabled = true;

        }

        private void uxBtnStopServer_Click(object sender, EventArgs e)
        {
            ws.Stop();
            uxBtnStopServer.Enabled = false;
            uxBtnStartServer.Enabled = true;
        }
    }
}