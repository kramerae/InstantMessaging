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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
            uxAddButton.Enabled = false;

        }

        private void uxAddTextBox_TextChanged(object sender, EventArgs e)
        {
            uxAddButton.Enabled = true;
        }
    }
}
