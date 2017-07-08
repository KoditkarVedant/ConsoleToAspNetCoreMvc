using System;
using Microsoft.AspNetCore.Hosting;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel();

            host.Start();
        }
    }
}
