using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.ImpuestosAut.Dtos;

namespace TestBase.Api.Models.ImpuestosAut
{
    public class ImpuestoAutRepository : Repository<ImpuestoAut>, IImpuestoAutRepository
    {
        public ImpuestoAutRepository(ApplicationDbContext context) : base(context)
        {
        }

        /*public ICollection<ImpuestoAutWebDto> CustomGetByQuery(ImpuestoAutQuery query)
        {
            if (query.Page < 0) return new List<ImpuestoAutWebDto>();

            Expression<Func<ImpuestoAut, bool>> whereTrue = e => true;
            var where = query.Where ?? whereTrue;

            if (query.OrderBy == null && query.OrderByDescending == null)
            {
                return Context.Set<ImpuestoAut>().Where(where).Select(e => new ImpuestoAutWebDto
                {
                    Id = e.Id,
                    Codigo = e.Codigo,
                    Nombre = e.Nombre,
                    Domicilio = e.Domicilio,
                    TipoEstablecimientoId = e.TipoEstablecimientoId,
                    ZonaId = e.ZonaId,
                   

                    

                })
                    .OrderBy(e => e.InsertedAt)
                    .Skip(query.Page * query.Top)
                    .Take(query.Top)
                    .ToList();
            }

            if (query.OrderBy != null)
            {
                return Context.Set<ImpuestoAut>().Where(where).Select(e => new ImpuestoAutWebDto
                {
                    Id = e.Id,
                    Codigo = e.Codigo,
                    Nombre = e.Nombre,
                    Domicilio = e.Domicilio,
                    TipoEstablecimientoId = e.TipoEstablecimientoId,
                    ZonaId = e.ZonaId,
                   
                })
                    .OrderBy(query.OrderBy)
                    .Skip(query.Page * query.Top)
                    .Take(query.Top)
                    .ToList();
            }

            return Context.Set<ImpuestoAut>().Where(where).Select(e => new ImpuestoAutWebDto
            {
                Id = e.Id,
                Codigo = e.Codigo,
                Nombre = e.Nombre,
                Domicilio = e.Domicilio,
                TipoEstablecimientoId = e.TipoEstablecimientoId,
                ZonaId = e.ZonaId,
               
            })
                .OrderByDescending(query.OrderByDescending)
                .Skip(query.Page * query.Top)
                .Take(query.Top)
                .ToList();
        }

        public ICollection<ImpuestoAutWebDto> CustomGetAll()
        {
            return Context.Establecimientos.Select(e => new ImpuestoAutWebDto
            {
                Id = e.Id,
                Codigo = e.Codigo,
                Nombre = e.Nombre,
                Domicilio = e.Domicilio,
                TipoEstablecimientoId = e.TipoEstablecimientoId
            }).OrderBy(e => e.Nombre).ToList();
        }*/
    }
}
