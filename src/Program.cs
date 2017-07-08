using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5000")
                .Build();

            host.Start();
            Console.WriteLine("Server is started...");
            Console.ReadKey();
        }
    }
}
