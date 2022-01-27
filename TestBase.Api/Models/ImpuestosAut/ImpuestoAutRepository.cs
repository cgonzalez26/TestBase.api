﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.ImpuestosAut.Dtos;
using TestBase.Api.Models.Titulares.Dtos;
using TestBase.Api.Models.Vehiculos;
using TestBase.Api.Models.VehiculosTitulares;
using TestBase.Api.Models.VehiculosTitulares.Dtos;

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
        public ICollection<ImpuestoAutWebDto> getByNroDocumento(string NroDocumento)
        {
            var imp_aut = from ia in Context.ImpuestosAut
                          join v in Context.Vehiculos on ia.VehiculoId equals v.Id
                          join vt in Context.VehiculosTitulares on v.Id equals vt.VehiculoId
                          join t in Context.Titulares on vt.TitularId equals t.Id
                          where t.sNroDocumento.Equals(NroDocumento)
                          select new ImpuestoAutWebDto
                          {
                              Id = ia.Id,
                              dFecha_Pago = ia.dFecha_Pago,
                              iAnio = ia.iAnio,
                              iPeriodo = ia.iPeriodo,
                              nMonto_Pagar = ia.nMonto_Pagar,
                              sDominio = ia.sDominio,
                              nPago = ia.nPago,
                              nSaldo = ia.nSaldo,
                              VehiculoId = ia.VehiculoId
                          };
            return imp_aut.ToList();

        }
    }
}
