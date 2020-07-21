using System;

using Microsoft.Extensions.Options;

using RawGitConfiguration = R5T.Nikaia.Configuration.Raw.GitConfiguration;


namespace R5T.Nikaia.Configuration
{
    public class GitConfigurationConfigureOptions : IConfigureOptions<GitConfiguration>
    {
        private IOptions<RawGitConfiguration> RawGitConfiguration { get; }


        public GitConfigurationConfigureOptions(IOptions<RawGitConfiguration> rawGitConfiguration)
        {
            this.RawGitConfiguration = rawGitConfiguration;
        }

        public void Configure(GitConfiguration options)
        {
            var rawGitConfiguration = this.RawGitConfiguration.Value;

            options.GitExecutableFilePath = rawGitConfiguration.GitExecutableFilePath;
        }
    }
}
