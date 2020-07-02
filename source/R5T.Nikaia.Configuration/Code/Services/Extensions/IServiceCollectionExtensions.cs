using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;


namespace R5T.Nikaia.Configuration
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitExecutableFilePathProvider"/> implementation of <see cref="IGitExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitExecutableFilePathProvider(this IServiceCollection services,
            IServiceAction<IOptions<GitConfiguration>> gitConfigurationAction)
        {
            services
                .AddSingleton<IGitExecutableFilePathProvider, GitExecutableFilePathProvider>()
                .Run(gitConfigurationAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitExecutableFilePathProvider"/> implementation of <see cref="IGitExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitExecutableFilePathProvider> AddGitExecutableFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IOptions<GitConfiguration>> gitConfigurationAction)
        {
            var serviceAction = ServiceAction.New<IGitExecutableFilePathProvider>(() => services.AddGitExecutableFilePathProvider(
                gitConfigurationAction));

            return serviceAction;
        }
    }
}
