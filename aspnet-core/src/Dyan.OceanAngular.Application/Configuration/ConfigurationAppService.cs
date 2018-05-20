using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dyan.OceanAngular.Configuration.Dto;

namespace Dyan.OceanAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OceanAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
