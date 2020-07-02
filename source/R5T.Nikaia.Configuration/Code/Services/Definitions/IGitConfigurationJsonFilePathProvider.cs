using System;
using System.Threading.Tasks;


namespace R5T.Nikaia.Configuration
{
    public interface IGitConfigurationJsonFilePathProvider
    {
        Task<string> GetGitConfigurationJsonFilePath();
    }
}
