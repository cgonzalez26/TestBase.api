using System.Collections.Generic;

namespace TestBase.Api.Models.Zonas
{
    public interface IZonaRepository : IRepository<Zona>
    {
        public ICollection<Zona> zonaByDepartamento(string departamentoId);
    }
}
