using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.ImpuestosInm
{
    public class ImpuestoInmRepository : Repository<ImpuestoInm>, IImpuestoInmRepository
    {
        public ImpuestoInmRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
