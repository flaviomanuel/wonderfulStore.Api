using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using WonderfulStore.Application.Commands.AddProduct;

namespace WonderfulStore.Api.Configurations
{
    public static class HandlersConfiguration
    {
         public static IServiceCollection AddHandlers(this IServiceCollection services){
            services.AddMediatR(typeof(AddProductCommand));

            return services;
        }
    }
}