using System.Threading.Tasks;
using Abp.Application.Services;
using EM.Authorization.Accounts.Dto;

namespace EM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
