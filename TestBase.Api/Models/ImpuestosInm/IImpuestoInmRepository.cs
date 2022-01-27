using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.ImpuestosInm.Dtos;

namespace TestBase.Api.Models.ImpuestosInm
{
    public interface IImpuestoInmRepository : IRepository<ImpuestoInm>
    {
        ICollection<ImpuestoInmWebDto> getByNroDocumento(string NroDocumento);
    }
}
