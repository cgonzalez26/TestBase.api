using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Establecimientos.Dtos;
using TestBase.Api.Models.ImpuestosAut.Dtos;

namespace TestBase.Api.Models.ImpuestosAut
{
    public interface IImpuestoAutRepository : IRepository<ImpuestoAut>
    {
        /* ICollection<EstablecimientoWebDto> CustomGetByQuery(EstablecimientoQuery query);

         ICollection<EstablecimientoWebDto> CustomGetAll();*/
        ICollection<ImpuestoAutWebDto> getByNroDocumento(string NroDocumento);
    }
}
