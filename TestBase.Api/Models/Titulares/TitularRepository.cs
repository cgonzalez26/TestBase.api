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
    }
}
