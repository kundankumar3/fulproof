using Microsoft.Owin.Hosting;
using System;

namespace WebOwinHosting
{
    public class Host
    {
        public static void Main(string[] args)
        {
            WebApp.Start<Startup>("http://+:8080");
            Console.WriteLine("server started at : http://localhost:8080 ");

            Console.ReadLine();
        }
    }
}
