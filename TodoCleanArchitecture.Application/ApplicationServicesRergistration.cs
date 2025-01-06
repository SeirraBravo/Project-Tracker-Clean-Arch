﻿using System;
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
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            //var assemblies = new Assembly[]
            //{
            //    Assembly.Load("ProjectTarcker.Domain"),
            //    Assembly.Load("ProjectTarcker.Infrastructure")
            //};
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
