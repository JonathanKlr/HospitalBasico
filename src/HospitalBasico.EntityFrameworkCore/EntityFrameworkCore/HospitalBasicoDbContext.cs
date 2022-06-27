using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HospitalBasico.Authorization.Roles;
using HospitalBasico.Authorization.Users;
using HospitalBasico.MultiTenancy;

namespace HospitalBasico.EntityFrameworkCore
{
    public class HospitalBasicoDbContext : AbpZeroDbContext<Tenant, Role, User, HospitalBasicoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HospitalBasicoDbContext(DbContextOptions<HospitalBasicoDbContext> options)
            : base(options)
        {
        }
    }
}
