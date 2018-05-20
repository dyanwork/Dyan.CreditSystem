using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dyan.OceanAngular.Configuration;

namespace Dyan.OceanAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(OceanAngularWebCoreModule))]
    public class OceanAngularWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OceanAngularWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OceanAngularWebHostModule).GetAssembly());
        }
    }
}
