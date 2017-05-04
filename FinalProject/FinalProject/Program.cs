using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public delegate bool Message(string message);

    public delegate void InputHandler(object sender, string[] items);

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

            // Create instance of model
            ClientModel model = new ClientModel();
            
            // Create instance of controller
            ClientController c = new ClientController(model);
            c.MessageEvent += c.MessageReceived;
            
            // Create instance of loginform 
            LoginForm loginform = new LoginForm(c.handle, model);
            c.register(loginform.LoginUpdate);
            loginform.ShowDialog();
            if (loginform.DialogResult != DialogResult.Cancel)
            {
                // Create instance of client menu
                ClientMenu menu = new ClientMenu(c.handle, model);
                menu.Show();
                c.register(menu.UpdateContactListBox);
                c.register(menu.UpdateChatRoomListBox);
                c.register(menu.UpdateMessageListBox);
                Application.Run(menu);
            }
            
        }
    }
}
