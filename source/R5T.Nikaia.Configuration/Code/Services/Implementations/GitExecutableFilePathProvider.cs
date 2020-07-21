using System;

using Microsoft.Extensions.Options;


namespace R5T.Nikaia.Configuration
{
    public class GitExecutableFilePathProvider : IGitExecutableFilePathProvider
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
