using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResPi.PitchManagement.Application.Contracts.Infrastructure;
using ResPi.PitchManagement.Application.Models.Mail;
using ResPi.PitchManagement.Infrastructure.FileExport;
using ResPi.PitchManagement.Infrastructure.Mail;

namespace ResPi.PitchManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<ICsvExporter, CsvExporter>();

            return services;
        }
    }
}
