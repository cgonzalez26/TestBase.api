using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.ImpuestosTsg
{
    public class ImpuestoTsgRepository : Repository<ImpuestoTsg>, IImpuestoTsgRepository
    {
        public ImpuestoTsgRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
