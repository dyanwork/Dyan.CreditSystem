using Abp.MultiTenancy;
using Dyan.OceanAngular.Authorization.Users;

namespace Dyan.OceanAngular.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
