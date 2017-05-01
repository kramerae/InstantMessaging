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
        private ClientModel _model;
        private InputHandler _handle;

        public AddContactForm(InputHandler han, ClientModel m)
        {
            _model = m;
            _handle = han;
            InitializeComponent();
            uxAddButton.Enabled = false;
        }

        private void uxAddTextBox_TextChanged(object sender, EventArgs e)
        {
            uxAddButton.Enabled = true;
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            string username = uxAddTextBox.Text;
            string[] arr = { "AC", username};
            _handle(this, arr);
        }
    }
}
