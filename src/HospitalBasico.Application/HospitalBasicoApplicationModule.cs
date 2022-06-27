using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HospitalBasico.Authorization;

namespace HospitalBasico
{
    [DependsOn(
        typeof(HospitalBasicoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HospitalBasicoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HospitalBasicoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HospitalBasicoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
