using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Usuarios.Dtos;

namespace TestBase.Api.Models.Usuarios
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        UsuarioWebDto Authenticate(string UsuarioNombre, string password, string secretKey, int expires);
    }
}
