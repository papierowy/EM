using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EM.MultiTenancy.Dto;

namespace EM.MultiTenancy
{
   public interface
      ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
   {
   }
}