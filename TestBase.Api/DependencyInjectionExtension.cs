using TestBase.Api.Models;
using TestBase.Api.Models.Roles;
using TestBase.Api.Services.Fcm;
using TestBase.Api.Services.HttpContext;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TestBase.Api.Models.Permisos;
using TestBase.Api.Models.RolPermisos;
using TestBase.Api.Models.TipoZonas;
using TestBase.Api.Models.Zonas;
using TestBase.Api.Models.Usuarios;
using TestBase.Api.Models.Establecimientos;
using TestBase.Api.Models.TipoEstablecimientos;
using AutoMapper;

namespace TestBase.Api
{
    public static class DependencyInjectionExtension
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IPermisoRepository), typeof(PermisoRepository));
            services.AddScoped(typeof(IRolRepository), typeof(RolRepository));
            services.AddScoped(typeof(IRolPermisoRepository), typeof(RolPermisoRepository));
            services.AddScoped(typeof(ITipoZonaRepository), typeof(TipoZonaRepository));
            services.AddScoped(typeof(IZonaRepository), typeof(ZonaRepository));
            services.AddScoped(typeof(IUsuarioRepository), typeof(UsuarioRepository));
            services.AddScoped(typeof(IEstablecimientoRepository), typeof(EstablecimientoRepository));
            services.AddScoped(typeof(ITipoEstablecimientoRepository), typeof(TipoEstablecimientoRepository));

            // Scoped Services
            services.AddScoped<IFcmService, FcmService>();

            // Transient Services
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<HttpContextService>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
