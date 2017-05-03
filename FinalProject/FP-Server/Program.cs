using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Windows.Forms;
using FP_Server.Model;

namespace FP_Server
{
    public delegate void Observer();
    public delegate void UserListUpdates(string s);
    public delegate void UpdateEvent(string s);
    public delegate void Logout(string s);
    public delegate void UpdateContacts(Dictionary<string, User_m> d);
 
    


    public interface UpdateDeligate
    {
        event UpdateEvent UpdateEventList;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Construct model
             ServerDatabase d = new ServerDatabase();

            // Construct Server Controlller
            // ServerController c = new ServerController(d);

            // Start a websocket server at port 8550
            //ServerForm sf = new ServerForm(wss);
            var wss = new WebSocketServer(8550);
            ServerForm sf = new ServerForm(wss, d);

          //  ServerController c = new ServerController(sf.UpdateListEvents, sf.UpdateUserLists, sf, d);
            // Add the Echo websocket service
            //wss.AddWebSocketService<Echo>("/echo");
            
            // Add the Chat websocket service
            wss.AddWebSocketService<ServerController>("/chat", () => new ServerController(sf.UpdateListEvents, sf.UpdateUserLists, sf, sf.UpdateContacts, d));

            sf.Show();

            //Construct Form
            Application.Run();
        

        }
    }
} 


