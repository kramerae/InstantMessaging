using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public delegate bool Message(string message);

    public delegate void InputHandler(object sender, string[] items);

    public delegate void LoginObserver(); 

    public delegate void MenuObserver();

    public delegate void UpdateContactList();

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClientModel model = new ClientModel();


       

            ClientController c = new ClientController(model);
            c.MessageEvent += c.MessageReceived;
            //LoginForm f = new LoginForm(c);

           
            LoginForm loginform = new LoginForm(c.handle, model);
            c.register(loginform.LoginUpdate);
            loginform.ShowDialog();

            if (loginform.DialogResult != DialogResult.Cancel)
            {
                MessageBox.Show("WORKED");

                ClientMenu menu = new ClientMenu(c.handle, model);
            }

            // cOMMENT
            Application.Run(loginform);
        }
    }
}
