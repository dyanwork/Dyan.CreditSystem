using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Dyan.OceanAngular.Authorization;
using Dyan.OceanAngular.Authorization.Roles;
using Dyan.OceanAngular.Authorization.Users;
using Dyan.OceanAngular.Editions;
using Dyan.OceanAngular.MultiTenancy;

namespace Dyan.OceanAngular.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
