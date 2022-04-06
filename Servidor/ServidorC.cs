using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Servidor
{
    class ServidorC
    {
        int port = 23422;
        string ip = "127.0.0.1";
        public void nuevoServer()
        {
            Socket serverListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            serverListener.Bind(endp);
            serverListener.Listen(100);
            Socket clientSocket = default(Socket);
            Servidor p = new Servidor();
            while (true)
            {
                clientSocket = serverListener.Accept();
                Thread UserThread = new Thread(new ThreadStart(() => p.User(clientSocket)));
                UserThread.Start();
            }
        }
       
}
}
