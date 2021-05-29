using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using sample.Configuration;
using sample.Web;

namespace sample.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class sampleDbContextFactory : IDesignTimeDbContextFactory<sampleDbContext>
    {
        public sampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<sampleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            sampleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(sampleConsts.ConnectionStringName));

            return new sampleDbContext(builder.Options);
        }
    }
}
