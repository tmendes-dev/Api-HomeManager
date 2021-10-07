
using ApplicationServices;
using Domain.Aggregate;
using Domain.Repositories;
using Domain.Services;
using Infra;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_HomeManager.AppConfig
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddRepositoriesDI(this IServiceCollection services)
        {
            services.AddTransient<IBasicRepository<ShopList>, ShopListRepository>();
            services.AddTransient<IBasicRepository<Product>, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {
            services.AddTransient<IShopListService, ShopListService>();
            services.AddTransient<IProductService, ProductService>();
            return services;
        }
    }
}
