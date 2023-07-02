using WonderfulStore.Core.Interfaces;
using WonderfulStore.Infrastructure.Persistence.Repositories;

namespace WonderfulStore.Api.Configurations
{
    public static class DependencyInjectionConfiguration 
    {
         public static IServiceCollection AddDependencyInjections(this IServiceCollection services){
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShoppingCartProductRepository, ShoppingCartProductRepository>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

            return services;
         }
    }
}