using WonderfulStore.Application.Commands.AddShoppingCartProduct.FactoryMethod;
using WonderfulStore.Application.Services;
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

            
            services.AddScoped<IPromotionServiceFactory, PromotionServiceFactory>();
            services.AddScoped<PromotionTake2Pay1Service>();
            services.AddScoped<Promotion3For10Service>();
            services.AddScoped<PromotionWithoutService>();

            return services;
         }
    }
}