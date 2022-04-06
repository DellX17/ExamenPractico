using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTeorico
{
    class client
    {
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public void coneksion()
        {
            int port = 6000;
            string ip = "127.0.0.1";
            IPEndPoint endp = new IPEndPoint(IPAddress.Parse(ip), port);
            clientSocket.Connect(endp);
            
        }
        public void mandarsendxdddd(string mensaje)
        {
            clientSocket.Send(System.Text.Encoding.UTF8.GetBytes(mensaje), 0, mensaje.Length, SocketFlags.None);
        }
        public string getString()
        {
            string mensajeRegreso;
            while (true)
            {
                byte[] msgFromServer = new byte[1024];
                int size = clientSocket.Receive(msgFromServer);
                mensajeRegreso = $"El server dice:{System.Text.Encoding.UTF8.GetString(msgFromServer, 0, size)}";
            }
            return mensajeRegreso;
        }
    }
}
