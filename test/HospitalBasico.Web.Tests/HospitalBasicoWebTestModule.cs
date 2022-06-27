using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HospitalBasico.EntityFrameworkCore;
using HospitalBasico.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HospitalBasico.Web.Tests
{
    [DependsOn(
        typeof(HospitalBasicoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HospitalBasicoWebTestModule : AbpModule
    {
        public HospitalBasicoWebTestModule(HospitalBasicoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HospitalBasicoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HospitalBasicoWebMvcModule).Assembly);
        }
    }
}