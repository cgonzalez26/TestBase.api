using AutoMapper;
using TestBase.Api.Models.Establecimientos;
using TestBase.Api.Models.Establecimientos.Dtos;
using TestBase.Api.Models.TipoZonas;
using TestBase.Api.Models.TipoZonas.Dtos;
using TestBase.Api.Models.Zonas;
using TestBase.Api.Models.Zonas.Dtos;

namespace TestBase.Api.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // TipoZona Web Dto
            CreateMap<TipoZona, TipoZonaWebDto>();
            CreateMap<TipoZonaWebDto, TipoZona>()
                .ForMember(m => m.Zonas, opt => opt.Ignore());

            // Zona Web Dto
            CreateMap<Zona, ZonaWebDto>();
            CreateMap<ZonaWebDto, Zona>()
                .ForMember(m => m.Padre, opt => opt.Ignore())
                .ForMember(m => m.Geometria, opt => opt.Ignore())
                .ForMember(m => m.TipoZona, opt => opt.Ignore());

            // Establecimiento Web Dto
            CreateMap<Establecimiento, EstablecimientoWebDto>();
            CreateMap<EstablecimientoWebDto, Establecimiento>()
                .ForMember(m => m.TipoEstablecimiento, opt => opt.Ignore())
                .ForMember(m => m.Zona, opt => opt.Ignore());
        }
    }
}
