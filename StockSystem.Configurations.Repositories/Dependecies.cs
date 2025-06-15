using Microsoft.Extensions.DependencyInjection;
using StockSystem.Domian.Interfaces.Repositories;
using SystemStock.Infrastructure.Repositories;

namespace StockSystem.Configurations.Repositories
{
    public static class Dependecies
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            return service;
        }
    }
}
