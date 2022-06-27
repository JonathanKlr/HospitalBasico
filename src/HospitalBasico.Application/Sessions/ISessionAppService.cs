using System.Threading.Tasks;
using Abp.Application.Services;
using HospitalBasico.Sessions.Dto;

namespace HospitalBasico.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
