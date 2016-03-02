using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace GitHubSpike.Model
{
    public class GitHubContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = PlatformServices.Default.Application.ApplicationBasePath;
            optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "github.db"));
        }
    }
}
