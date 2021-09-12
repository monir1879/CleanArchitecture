using CleanArch.Application.Automapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.API.Configurations
{
    public static class AutomapperConfig
    {
        public static void RegisterAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.Automapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
