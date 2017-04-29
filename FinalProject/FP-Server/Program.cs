using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Windows.Forms;

namespace FP_Server
{
    public delegate void UpdateEvent(string s);

    public interface UpdateDeligate
    {
        event UpdateEvent UpdateEventList;
    }





    class Program
    {
        static void Main(string[] args)
        {
            // Construct model

            // ServerDatabase d = new ServerDatabase();

            // Construct Server Controlller
            // ServerController c = new ServerController(d);

            // Start a websocket server at port 8550

            //ServerForm sf = new ServerForm(wss);
            var wss = new WebSocketServer(8550);
            ServerForm sf = new ServerForm(wss);
            // Add the Echo websocket service
            //wss.AddWebSocketService<Echo>("/echo");

            // Add the Chat websocket service
            wss.AddWebSocketService<ServerController>("/chat", () => new ServerController(sf.UpdateListEvents, sf));

            sf.Show();

            //Construct Form

           


            Application.Run();
            
           // Console.WriteLine("Press Enter to exit.");
           // Console.ReadLine();

            // Stop the server
          //  wss.Stop();

        }
    }
} 


