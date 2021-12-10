using System.Collections.Generic;
using System.Threading.Tasks;
using TestBase.Api.Models.Permisos.Dtos;

namespace TestBase.Api.Models.Permisos
{
    public interface IPermisoRepository : IRepository<Permiso>
    {
        ICollection<PermisoWebDto> GetByRolId(string rolId);

        Task<ICollection<PermisoWebDto>> GetByRolIdAsync(string rolId);
    }
}
