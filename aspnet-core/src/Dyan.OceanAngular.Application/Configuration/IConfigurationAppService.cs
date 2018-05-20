using System.Threading.Tasks;
using Dyan.OceanAngular.Configuration.Dto;

namespace Dyan.OceanAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
