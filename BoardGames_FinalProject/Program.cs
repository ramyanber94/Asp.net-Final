using BoardGames_FinalProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGames_FinalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

                Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Service.GetBoardGames().games.PrintDump();
                  
                    /*
                    webBuilder.UseStartup<Startup>();
                    */
                    webBuilder.UseStartup<Startup>()
                    .UseDefaultServiceProvider(           // add this
                        options => options.ValidateScopes = false);

                });
    }
}
