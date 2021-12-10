using TestBase.Api.Models.Roles;
using Microsoft.EntityFrameworkCore;

namespace TestBase.Api.Migrations.Seed
{
    public static class RolSeed
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = "COD_ADMIN", Nombre = "Super Admin", Descripcion = "Super Admin" }
            );
        }
    }
}
