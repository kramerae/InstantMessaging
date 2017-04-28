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
    class Program
    {
        static void Main(string[] args)
        {
            // Construct model

           // ServerDatabase d = new ServerDatabase();

            // Construct Server Controlller
            // ServerController c = new ServerController(d);

            // Start a websocket server at port 8550
            var wss = new WebSocketServer(8550);
           
            // Add the Echo websocket service
            wss.AddWebSocketService<Echo>("/echo");

            // Add the Chat websocket service
            wss.AddWebSocketService<ServerController>("/chat");


            //Construct Form

            ServerForm sf = new ServerForm(wss);


            Application.Run(sf);
            
           // Console.WriteLine("Press Enter to exit.");
           // Console.ReadLine();

            // Stop the server
          //  wss.Stop();

        }
    }
} 


