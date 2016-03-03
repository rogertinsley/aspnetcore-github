using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitHubSpike.Services.Model;

namespace GitHubSpike.Services
{
    public interface IGitHubGateway
    {
        Task<ICollection<Repository>> RetrieveRepositories();
    }

    public class GitHubGateway : IGitHubGateway
    {
        public Task<ICollection<Repository>> RetrieveRepositories()
        {
            throw new NotImplementedException();
        }
    }
}
