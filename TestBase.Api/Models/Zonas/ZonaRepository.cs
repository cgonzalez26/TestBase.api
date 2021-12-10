using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestBase.Api.Models.Zonas
{
    public class ZonaRepository : Repository<Zona>, IZonaRepository
    {
        public ZonaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
