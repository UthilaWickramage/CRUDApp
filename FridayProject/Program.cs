using FridayProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace FridayProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection();
            services.AddTransient<SignIn>();
            //services.AddTransient<MyDBContext>();
            //services.AddDbContext<MyDBContext>(options =>
            //{
            //    options.UseSqlServer("server=AXCITO-DEV-01;database=FridayDB;User Id=sa;Password=axcito@SQL;TrustServerCertificate=True;");

            //});


            using ServiceProvider serviceProvider = services.BuildServiceProvider();
          
            var form = serviceProvider.GetRequiredService<SignIn>();
            Application.Run(form);

        }
    }
}