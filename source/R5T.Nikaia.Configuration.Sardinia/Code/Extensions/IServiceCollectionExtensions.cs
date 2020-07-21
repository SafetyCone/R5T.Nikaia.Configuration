using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Sardinia;


namespace R5T.Nikaia.Configuration
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitConfiguration(this IServiceCollection services)
        {
            services
                .Configure<Raw.GitConfiguration>()
                .ConfigureOptions<GitConfigurationConfigureOptions>()
                ;

            return services;
        }

        public static IServiceAction<IOptions<GitConfiguration>> AddGitConfigurationAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IOptions<GitConfiguration>>.New(() => services.AddGitConfiguration());
            return serviceAction;
        }
    }
}
