using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dyan.OceanAngular.MultiTenancy.Dto;

namespace Dyan.OceanAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
