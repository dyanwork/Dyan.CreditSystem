using System.Threading.Tasks;
using Abp.Application.Services;
using Dyan.OceanAngular.Authorization.Accounts.Dto;

namespace Dyan.OceanAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
