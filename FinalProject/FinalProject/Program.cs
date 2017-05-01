using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public delegate bool Message(string message);

    public delegate void InputHandler(object sender, string[] items);

    public delegate bool LoginObserver(); 

    public delegate void Observer();

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

            ClientModel cm = new ClientModel();

            ClientController c = new ClientController(cm);
            c.MessageEvent += c.MessageReceived;
            //LoginForm f = new LoginForm(c);
            LoginForm f = new LoginForm(c.handle, cm);
            Application.Run(f);
        }
    }
}
