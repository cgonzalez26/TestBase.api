using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.ImpuestosTsg.Dtos;

namespace TestBase.Api.Models.ImpuestosTsg
{
    public interface IImpuestoTsgRepository : IRepository<ImpuestoTsg>
    {
        ICollection<ImpuestoTsgWebDto> getByNroDocumento(string NroDocumento);

        int getCountDeudaByNroDocumento(string NroDocumento);
    }
}
