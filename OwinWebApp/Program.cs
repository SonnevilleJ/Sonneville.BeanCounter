using System;
using Microsoft.Owin.Hosting;

namespace OwinWebApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const int port = 1234;
            string baseAddress = $"http://*:{port}/";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine($"Listening on {baseAddress}");
                Console.ReadLine();
            }
        }
    }
}
