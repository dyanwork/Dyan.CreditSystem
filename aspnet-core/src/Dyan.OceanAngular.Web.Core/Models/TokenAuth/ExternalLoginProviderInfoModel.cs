using Abp.AutoMapper;
using Dyan.OceanAngular.Authentication.External;

namespace Dyan.OceanAngular.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
