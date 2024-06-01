using Adwaith1.Application.Database;
using Adwaith1.Application.Events.Listeners;
using Adwaith1.Application.Jobs;
using Adwaith1.Application.Models;
using Adwaith1.Application.Services.Auth;
using Adwaith1.Pages.Auth;
using Coravel;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Spark.Library.Auth;
using Spark.Library.Database;
using Spark.Library.Mail;
using Vite.AspNetCore.Extensions;

namespace Adwaith1.Application.Startup
{
    public static class AppServicesRegistration
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddViteServices();
            services.AddCustomServices();
            services.AddDatabase<DatabaseContext>(config);
            services.AddAuthorization(config, new string[] { CustomRoles.Admin, CustomRoles.User });
            services.AddAuthentication<IAuthValidator>(config);
            services.AddJobServices();
            services.AddScheduler();
            services.AddQueue();
            services.AddEventServices();
            services.AddEvents();
            services.AddMailer(config);
            services.AddRazorComponents();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".Adwaith1";
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });
            return services;
        }

        private static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            // add custom services
            services.AddScoped<UsersService>();
            services.AddScoped<RolesService>();
            services.AddScoped<IAuthValidator, SparkAuthValidator>();
            services.AddScoped<AuthService>();
            services.AddScoped<IValidator<Register.RegisterForm>, Register.RegisterFormValidator>();
            return services;
        }

        private static IServiceCollection AddEventServices(this IServiceCollection services)
        {
            // add custom events here
            services.AddTransient<EmailNewUser>();
            return services;
        }

        private static IServiceCollection AddJobServices(this IServiceCollection services)
        {
            // add custom background tasks here
            services.AddTransient<ExampleJob>();
            return services;
        }
    }
}
