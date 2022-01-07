using TestBase.Api.Migrations.Seed;
using Microsoft.EntityFrameworkCore;
using TestBase.Api.Models.Permisos;
using TestBase.Api.Models.Roles;
using TestBase.Api.Models.RolPermisos;
using TestBase.Api.Models.TipoZonas;
using TestBase.Api.Models.Zonas;
using TestBase.Api.Models.TipoEstablecimientos;
using TestBase.Api.Models.Establecimientos;
using TestBase.Api.Models.ImpuestosAut;

namespace TestBase.Api.Models
{
    public static class ModelBuilderExtension
    {
        public static void ApplyConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PermisoConfiguration());
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new RolPermisoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoZonaConfiguration());
            modelBuilder.ApplyConfiguration(new ZonaConfiguration());
            modelBuilder.ApplyConfiguration(new TipoEstablecimientoConfiguration());
            modelBuilder.ApplyConfiguration(new EstablecimientoConfiguration());
            modelBuilder.ApplyConfiguration(new ImpuestoAutConfiguration());
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedPermisos();
            modelBuilder.SeedRoles();
            modelBuilder.SeedRolPermisos();
            modelBuilder.SeedTipoEstablecimientos();
            modelBuilder.SeedZonas();
            modelBuilder.SeedEstablecimientos();
        }
    }
}
