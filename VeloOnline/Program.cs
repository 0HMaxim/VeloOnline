using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeloOnline.Models;

namespace VeloOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var bikeContext = services.GetRequiredService<BikeContext>();
                    var identityContext = services.GetRequiredService<Models.IdentityDbContext>();

                    var userManager = services.GetRequiredService<UserManager<User>>();

                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                    TestData.Initialize(bikeContext, userManager, roleManager);
                }
                catch (Exception ex)
                {   
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "DB seeding error");
                }
            }

            host.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
