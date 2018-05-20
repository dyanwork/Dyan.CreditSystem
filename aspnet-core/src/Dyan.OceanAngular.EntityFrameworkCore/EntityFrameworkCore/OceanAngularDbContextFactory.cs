using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dyan.OceanAngular.Configuration;
using Dyan.OceanAngular.Web;

namespace Dyan.OceanAngular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OceanAngularDbContextFactory : IDesignTimeDbContextFactory<OceanAngularDbContext>
    {
        public OceanAngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OceanAngularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OceanAngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OceanAngularConsts.ConnectionStringName));

            return new OceanAngularDbContext(builder.Options);
        }
    }
}
