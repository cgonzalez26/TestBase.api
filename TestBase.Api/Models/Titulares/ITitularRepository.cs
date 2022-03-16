using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Titulares.Dtos;

namespace TestBase.Api.Models.Titulares
{
    public interface ITitularRepository : IRepository<Titular>
    {
        Titular getByNroDocumento(string NroDocumento);
        ICollection<Deudores> deudoresByZona(string zonaId);
    }
}
