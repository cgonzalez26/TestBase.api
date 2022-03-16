using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Titulares.Dtos;

namespace TestBase.Api.Models.Titulares
{
    public class TitularRepository : Repository<Titular>, ITitularRepository
    {
        public TitularRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Titular getByNroDocumento(string NroDocumento) 
        {
            return Context.Titulares.Where(e => e.sNroDocumento.Equals(NroDocumento)).FirstOrDefault();
        }

        public ICollection<Deudores> deudoresByZona(string zonaid)
        {
            var deudores_aut = from itsg in Context.ImpuestosAut
                               join vt in Context.VehiculosTitulares on itsg.VehiculoId equals vt.VehiculoId
                               join t in Context.Titulares on vt.TitularId equals t.Id
                               where itsg.nPago < itsg.nMonto_Pagar
                               select new
                               {
                                   itsg.sDominio,
                                   t.sNombre,
                                   t.sApellido,
                                   t.sDomicilio,
                                   t.sTelefono,
                                   t.sCelular,
                                   t.ZonaId
                               };
            var deudores_inm = from iinm in Context.ImpuestosInm
                               join it in Context.InmueblesTitulares on iinm.InmuebleId equals it.InmuebleId
                               join t in Context.Titulares on it.TitularId equals t.Id
                               where iinm.nPago < iinm.nMonto_Pagar
                               select new
                               {
                                   iinm.sCatastro,
                                   t.sNombre,
                                   t.sApellido,
                                   t.sDomicilio,
                                   t.sTelefono,
                                   t.sCelular,
                                   t.ZonaId
                               };
            ICollection<Deudores> deudores = null;
            Deudores deudor = null;
            if (deudores_aut.Count() > 0)
            {
                foreach (var deu_aut in deudores_aut)
                {
                    deudor = new Deudores
                    {
                        sCatastro = deu_aut.sDomicilio,
                        sApellido = deu_aut.sApellido,
                        sNombre = deu_aut.sNombre,
                        sDomicilio = deu_aut.sDomicilio,
                        sTelefono = deu_aut.sTelefono,
                        ZonaId = deu_aut.ZonaId
                    };
                    deudores.Add(deudor);
                }
            }

            foreach (var deu_inm in deudores_inm)
            {
                deudor = new Deudores
                {
                    sCatastro = deu_inm.sCatastro,
                    sApellido = deu_inm.sApellido,
                    sNombre = deu_inm.sNombre,
                    sDomicilio = deu_inm.sDomicilio,
                    sTelefono = deu_inm.sTelefono,
                    ZonaId = deu_inm.ZonaId
                };
                deudores.Add(deudor);
            }

            /*var deudores = from i in Context.Inmuebles 
                          join it in Context.InmueblesTitulares on i.Id equals it.InmuebleId
                          join t in Context.Titulares on it.TitularId equals t.Id
                          where (i.ZonaId.Equals(zonaid) || (zonaid == null))

                          select new Deudores
                          {                              
                              sCatastro = i.sCatastro,
                              sNombre = t.sNombre,
                              sApellido = t.sApellido,
                              sDomicilio = t.sDomicilio,
                              sTelefono = t.sTelefono,
                              sCelular = t.sCelular
                          };
            return deudores.ToList();*/
            return deudores;
        }
    }
}
