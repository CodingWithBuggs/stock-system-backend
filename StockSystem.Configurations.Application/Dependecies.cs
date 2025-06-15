using Microsoft.Extensions.DependencyInjection;
using StockSystem.Application.Services;
using StockSystem.Domian.Interfaces.Services;

namespace StockSystem.Configurations.Application
{
    public static class Dependecies
    {

        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddTransient<IProductTypeService, ProductTypeService>();
            return service;
        }
    }
}
