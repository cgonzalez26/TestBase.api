﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.TipoEstablecimientos
{
    public class TipoEstablecimientoRepository : Repository<TipoEstablecimiento>, ITipoEstablecimientoRepository
    {
        public TipoEstablecimientoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
