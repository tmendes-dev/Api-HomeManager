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
            return services;
        }

        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
