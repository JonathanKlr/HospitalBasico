using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HospitalBasico.Configuration;

namespace HospitalBasico.Web.Host.Startup
{
    [DependsOn(
       typeof(HospitalBasicoWebCoreModule))]
    public class HospitalBasicoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HospitalBasicoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HospitalBasicoWebHostModule).GetAssembly());
        }
    }
}
