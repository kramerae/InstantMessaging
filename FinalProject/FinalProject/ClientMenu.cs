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

        public ClientMenu(ClientController c)
        {
            _c = c;
            InitializeComponent();
        }

        private void uxLogout_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveContact_Click(object sender, EventArgs e)
        {

        }

        private void uxAddContact_Click(object sender, EventArgs e)
        {

        }

        private void uxStartChat_Click(object sender, EventArgs e)
        {

        }
    }
}
