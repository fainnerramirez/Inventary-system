using InventarySystem.Application.Services.ProductsService;
using InventarySystem.Infraestructure.Data;
using InventarySystem.Infraestructure.Repositories;
using InventarySystem.presentation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventarySystem
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string cs = config.GetConnectionString("Default")!;

            var services = new ServiceCollection();
            
            services.AddSingleton<IDbConnectionFactory>(new SqlConnectionFactory(cs));
            
            // repos
            services.AddTransient<IProductRepository, ProductRepository>();
            
            // services
            services.AddTransient<IProductService, ProductService>();

            // forms
            services.AddTransient<FrmMain>();

            var provider = services.BuildServiceProvider();

            System.Windows.Forms.Application.Run(provider.GetRequiredService<FrmMain>());
        }
    }
}
