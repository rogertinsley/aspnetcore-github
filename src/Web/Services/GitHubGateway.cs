using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitHubSpike.Services.Model;

namespace GitHubSpike.Services
{
    public interface IGitHubGateway
    {
        Task<ICollection<Issue>> GetIssues();
    }

    public class GitHubGateway : IGitHubGateway
    {
        public async Task<ICollection<Issue>> GetIssues()
        {
            using (var client = new HttpClient())
            {
                return new List<Issue>();
            }
        }
    }
}
