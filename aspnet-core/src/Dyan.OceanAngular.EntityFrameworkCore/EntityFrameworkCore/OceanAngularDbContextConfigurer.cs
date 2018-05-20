using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dyan.OceanAngular.EntityFrameworkCore
{
    public static class OceanAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OceanAngularDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OceanAngularDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
