using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace VerifyConecction
{
    class Program
    {

        private static void ping()
        {
            string ip = "192.168.1.109"; // Cambia esta dirección IP por la que quieras verificar

            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(ip);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("La conexión con {0} es exitosa. El tiempo de respuesta es {1} ms.", ip, reply.RoundtripTime);
                }
                else
                {
                    Console.WriteLine("La conexión con {0} falló. Estado: {1}", ip, reply.Status);
                }
            }
            catch (PingException ex)
            {
                Console.WriteLine("Error al intentar conectarse con {0}: {1}", ip, ex.Message);
            }
        }
        

        static void Main(string[] args)
        {
            ping(); 
        }
    }
}

 

 
