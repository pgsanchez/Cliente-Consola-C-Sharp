using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;           // Paso 1
using System.Net.Sockets;   // Paso 1

namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 2: crear un socket
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Paso 3: configurar la dirección a la que nos vamos a conectar
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            try
            {
                // Paso 4: conectar con el servidor
                socket1.Connect(direccion);

                Console.WriteLine("Cliente conectado con exito");
                Console.WriteLine("Cerrando...");
                socket1.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error {0}", error.ToString());
            }

            Console.WriteLine("Fin del programa. Presione cualquier tecla...");
            Console.ReadLine();
        }
    }
}
