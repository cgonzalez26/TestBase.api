﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.Vehiculos
{
    public class VehiculoRepository : Repository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
