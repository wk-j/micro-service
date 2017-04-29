using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MicroServiceApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                /*/
                .ConfigureConfiguration((context, configBuilder) => {
                    configBuilder
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true)
                        .AddEnvironmentVariables();
                })
                */
                .ConfigureLogging(loggerFactory => loggerFactory
                    .AddConsole()
                    .AddDebug())
                .UseStartup<Startup>()
                .Configure( app => {
                    app.UseRouter(r => {
                        //r.MapGet("contacts", (req, res, data)  => {

                        //});
                    });
                })
                .Build();

            host.Run();
        }
    }
}
