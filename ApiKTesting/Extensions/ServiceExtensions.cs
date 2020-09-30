using System.ComponentModel.Design;
using Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ApiKTesting.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(opt =>

            {
                opt.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                );
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(opt =>
            {

            });
        
        public static void ConfigureLoggerService(this IServiceCollection services)=>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }
}