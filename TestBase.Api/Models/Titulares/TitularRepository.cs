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

        public List<Deudores> deudoresByZona(string zonaid)
        {
            var deudores_aut = (from itsg in Context.ImpuestosAut
                               join vt in Context.VehiculosTitulares on itsg.VehiculoId equals vt.VehiculoId
                               join t in Context.Titulares on vt.TitularId equals t.Id
                               where itsg.nPago < itsg.nMonto_Pagar
                               && (t.ZonaId == zonaid || zonaid.Equals("ID_ALL"))
                               select new
                               {
                                   //itsg.sDominio,
                                   t.sNroDocumento,
                                   t.sNombre,
                                   t.sApellido,
                                   t.sDomicilio,
                                   t.sTelefono,
                                   t.sCelular,
                                   t.ZonaId
                               }).Distinct();
            var deudores_inm = (from iinm in Context.ImpuestosInm
                               join it in Context.InmueblesTitulares on iinm.InmuebleId equals it.InmuebleId
                               join t in Context.Titulares on it.TitularId equals t.Id
                               where iinm.nPago < iinm.nMonto_Pagar
                               && (t.ZonaId == zonaid || zonaid.Equals("ID_ALL"))
                               select new
                               {
                                   //iinm.sCatastro,
                                   t.sNroDocumento,
                                   t.sNombre,
                                   t.sApellido,
                                   t.sDomicilio,
                                   t.sTelefono,
                                   t.sCelular,
                                   t.ZonaId
                               }).Distinct();
            var deudores_tsg = (from itsg in Context.ImpuestosTsg
                                join it in Context.InmueblesTitulares on itsg.InmuebleId equals it.InmuebleId
                                join t in Context.Titulares on it.TitularId equals t.Id
                                where itsg.nPago < itsg.nMonto_Pagar
                                && (t.ZonaId == zonaid || zonaid.Equals("ID_ALL"))
                                select new
                                {
                                    //iinm.sCatastro,
                                    t.sNroDocumento,
                                    t.sNombre,
                                    t.sApellido,
                                    t.sDomicilio,
                                    t.sTelefono,
                                    t.sCelular,
                                    t.ZonaId
                                }).Distinct();

            List<Deudores> deudores = new List<Deudores>();
            deudores_aut.Union(deudores_inm);
            deudores_aut.Union(deudores_tsg);
            Deudores deudor = null;
            if (deudores_aut.Count() > 0)
            {
                foreach (var deu_aut in deudores_aut)
                {
                    deudor = new Deudores
                    {
                        //sCatastro = deu_aut.sDomicilio,
                        sNroDocumento = deu_aut.sNroDocumento,
                        sApellido = deu_aut.sApellido,
                        sNombre = deu_aut.sNombre,
                        sDomicilio = deu_aut.sDomicilio,
                        sTelefono = deu_aut.sTelefono,
                        ZonaId = deu_aut.ZonaId
                    };
                    deudores.Add(deudor);
                }
            }
            return deudores.ToList();
        }
    }
}
