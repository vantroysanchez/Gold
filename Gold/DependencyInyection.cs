using Gold.Infrastructure;
using Gold.Interfaces;
using Gold.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Gold
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {            

            services.AddDbContext<GoldDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("AdventureWorks2019dbConnection")));

            services.AddScoped<IGoldDbContext>(provider => provider.GetRequiredService<GoldDbContext>());

            services.AddTransient<IContactTypeService, ContactTypeService>();

            return services;
        }
    }
}
