using AMS.Domain;
using AMS.Domain.Repositories;
using AMS.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            services.AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
