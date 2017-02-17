using System;
using Microsoft.Owin.Hosting;
using UnixSignalWaiter;

namespace OwinWebApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const int port = 80;
            string baseAddress = $"http://*:{port}/";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine($"Listening on {baseAddress}");
                SignalWaiter.Instance.WaitExitSignal();
            }
        }
    }
}
