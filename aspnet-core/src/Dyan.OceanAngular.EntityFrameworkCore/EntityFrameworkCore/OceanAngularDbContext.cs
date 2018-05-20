using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dyan.OceanAngular.Authorization.Roles;
using Dyan.OceanAngular.Authorization.Users;
using Dyan.OceanAngular.MultiTenancy;

namespace Dyan.OceanAngular.EntityFrameworkCore
{
    public class OceanAngularDbContext : AbpZeroDbContext<Tenant, Role, User, OceanAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OceanAngularDbContext(DbContextOptions<OceanAngularDbContext> options)
            : base(options)
        {
        }
    }
}
