using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
