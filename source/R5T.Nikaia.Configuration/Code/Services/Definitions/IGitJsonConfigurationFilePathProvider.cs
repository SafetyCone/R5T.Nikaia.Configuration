using System;
using System.Threading.Tasks;


namespace R5T.Nikaia.Configuration
{
    public interface IGitJsonConfigurationFilePathProvider
    {
        Task<string> GetGitJsonConfigurationFilePath();
    }
}
