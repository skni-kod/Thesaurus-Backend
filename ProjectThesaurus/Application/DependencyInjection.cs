using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var asembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(configuration => 
                configuration.RegisterServicesFromAssembly(asembly));
            services.AddValidatorsFromAssembly(asembly);
            return services;
        }
}