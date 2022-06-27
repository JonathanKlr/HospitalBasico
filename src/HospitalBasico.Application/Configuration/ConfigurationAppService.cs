using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HospitalBasico.Configuration.Dto;

namespace HospitalBasico.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HospitalBasicoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
