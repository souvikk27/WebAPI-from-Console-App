// See https://aka.ms/new-console-template for more information
using ConsoleToWebAPI;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;
public class Program
{
    static void Main()
    {
        CreateHostBuilder().Build().Run();
    }
    public static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHost => {
            webHost.UseStartup<Startup>();
        });
    }
}
