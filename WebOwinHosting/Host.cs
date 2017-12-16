using Microsoft.Owin.Hosting;
using System;

namespace WebOwinHosting
{
    public class Host
    {
        public static void Main(string[] args)
        {
            WebApp.Start<Startup>("http://+:8090");
            Console.WriteLine("server started at : http://localhost:8090 ");

            Console.ReadLine();
        }
    }
}
