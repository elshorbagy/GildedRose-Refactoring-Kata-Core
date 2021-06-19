using csharpcore.Repository;
using csharpcore.Services;
using csharpcore.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace csharpcore
{
    public static class Ioc
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = ServiceProvider();
            serviceProvider.GetService<IInventoryRepository>();
            serviceProvider.GetService<IInventoryUpdateFactory>();
            return serviceProvider;
        }

        private static ServiceProvider ServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IInventoryUpdateFactory, InventoryUpdateFactory>();
            services.AddSingleton<IInventoryRepository, InventoryRepository>();
            services.AddSingleton<IInventoryService, InventoryService>();
            return services.BuildServiceProvider();
        }
    }
}
