using Abp.Application.Services;
using HospitalBasico.MultiTenancy.Dto;

namespace HospitalBasico.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

