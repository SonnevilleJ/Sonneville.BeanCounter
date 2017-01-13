using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace OwinWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:1234/";

            using (WebApp.Start<Startup>(baseAddress))
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(baseAddress + "api/hello").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}
