using System.Threading.Tasks;
using Abp.Application.Services;
using Dyan.OceanAngular.Sessions.Dto;

namespace Dyan.OceanAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
