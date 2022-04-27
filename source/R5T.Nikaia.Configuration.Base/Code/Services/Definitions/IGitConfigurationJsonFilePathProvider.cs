using System;using R5T.T0064;


namespace R5T.Nikaia.Configuration
{[ServiceDefinitionMarker]
    public interface IGitConfigurationJsonFilePathProvider:IServiceDefinition
    {
        string GetGitConfigurationJsonFilePath();
    }
}
