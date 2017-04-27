using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
0using System.Windows.Forms;

namespace FinalProject
{
    public delegate bool Message(string message);
    
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
            
            ClientController c = new ClientController();
            c.MessageEvent += c.MessageReceived;
            LoginForm f = new LoginForm(c);
            Application.Run(f);
        }
    }
}
