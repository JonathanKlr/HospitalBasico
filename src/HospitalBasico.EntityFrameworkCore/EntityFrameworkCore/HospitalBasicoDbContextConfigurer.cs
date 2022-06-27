using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HospitalBasico.EntityFrameworkCore
{
    public static class HospitalBasicoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HospitalBasicoDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString, ServerVersion.Parse("10.4.20-MariaDB"));
        }

        public static void Configure(DbContextOptionsBuilder<HospitalBasicoDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection, ServerVersion.Parse("10.4.20-MariaDB"));
        }
    }
}
