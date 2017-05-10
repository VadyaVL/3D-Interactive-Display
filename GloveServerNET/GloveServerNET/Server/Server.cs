using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloveServerNET
{
    public class Server
    {
        private HttpListener _httpListener;
        private Thread _responseThread;
        private bool run = true;
        public Server()
        {
            _httpListener = new HttpListener();
        }

        public void RunServer(String IP, String Port)
        {
            Console.WriteLine("Starting server...");
            _httpListener.Prefixes.Add("http://" + IP + ":" + Port + "/"); // add prefix "http://localhost:5000/"
            Console.WriteLine("http://" + IP + ":" + Port + "/");
            _httpListener.Start(); // start server (Run application as Administrator!)
            Console.WriteLine("Server started.");
            _responseThread = new Thread(ResponseThread);
            _responseThread.Start(); // start the response thread
        }

        public void StopServer()
        {
            run = false;
        }

        private void ResponseThread()
        {
            while (run)
            {
                HttpListenerContext context = _httpListener.GetContext(); // get a context
                // Now, you'll find the request URL in context.Request.Url
                byte[] _responseArray = Encoding.UTF8.GetBytes(Program.mainForm.GetStateAsJSON()); // get the bytes to response
                context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length); // write bytes to the output stream
                context.Response.KeepAlive = false; // set the KeepAlive bool to false
                context.Response.Close(); // close the connection
                Console.WriteLine("Respone given to a request.");
            }
        }
    }
}
