using System.Threading.Tasks;
using Abp.Application.Services;
using EM.Sessions.Dto;

namespace EM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
