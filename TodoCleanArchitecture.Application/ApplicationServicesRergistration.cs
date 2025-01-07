using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectTracker.Application
{
    public static class ApplicationServicesRergistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, MediatRServiceConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(configuration);
            return services;

        }
    }
}
