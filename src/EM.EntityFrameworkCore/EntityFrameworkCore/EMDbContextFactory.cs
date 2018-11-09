using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EM.Configuration;
using EM.Web;

namespace EM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EMDbContextFactory : IDesignTimeDbContextFactory<EMDbContext>
    {
        public EMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EMConsts.ConnectionStringName));

            return new EMDbContext(builder.Options);
        }
    }
}
