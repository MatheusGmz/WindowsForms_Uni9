using Autofac.Core;
using AutoMapper;
using ItemManager.Domain.ValueObjects;
using ItemManager.Infrastructure.Context;
using ItemManager.Infrastructure.Repository;
using ItemManager.Screens;
using Manager.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ItemManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            services.AddSingleton(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<Login>();
                Application.Run(form);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ManagerContext>();
            services.AddScoped<FuncionarioRepository>();
            services.AddScoped<ItemRepository>();
            services.AddScoped<FuncionarioServices>();
            services.AddScoped<ItemServices>();
            services.AddScoped<ManagerOptions>();
            services.AddScoped<ManagerContext>();
            services.AddScoped<Login>();
            services.AddScoped<ConfigurationKeys>();
            
        }
    }
}
