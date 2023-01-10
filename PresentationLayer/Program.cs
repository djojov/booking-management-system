using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(login);
            }
        }
        
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminBusiness, AdminBusiness>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientBusiness, ClientBusiness>();
            services.AddScoped<IAccommodationRepository, AccommodationRepository>();
            services.AddScoped<IAccommodationBusiness, AccommodationBusiness>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationBusiness, ReservationBusiness>();
            services.AddScoped<LoginForm>();
        }
    }
}