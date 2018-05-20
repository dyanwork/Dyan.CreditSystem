using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dyan.OceanAngular.Authorization;

namespace Dyan.OceanAngular
{
    [DependsOn(
        typeof(OceanAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OceanAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OceanAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OceanAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
