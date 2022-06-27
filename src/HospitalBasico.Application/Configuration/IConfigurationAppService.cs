using System.Threading.Tasks;
using HospitalBasico.Configuration.Dto;

namespace HospitalBasico.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
