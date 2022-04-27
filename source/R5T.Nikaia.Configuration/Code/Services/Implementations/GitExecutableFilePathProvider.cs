using System;

using Microsoft.Extensions.Options;using R5T.T0064;


namespace R5T.Nikaia.Configuration
{[ServiceImplementationMarker]
    public class GitExecutableFilePathProvider : IGitExecutableFilePathProvider,IServiceImplementation
    {
        private IOptions<GitConfiguration> GitConfiguration { get; }


        public GitExecutableFilePathProvider(IOptions<GitConfiguration> gitConfiguration)
        {
            this.GitConfiguration = gitConfiguration;
        }

        public string GetGitExecutableFilePath()
        {
            var gitConfiguration = this.GitConfiguration.Value;

            var gitExecutableFilePath = gitConfiguration.GitExecutableFilePath;
            return gitExecutableFilePath;
        }
    }
}
