﻿using StoredProcedureEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Titulares.Dtos;

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

        public dynamic deudoresByZona(string zonaid)
        {
            List<Deudores> rows = new List<Deudores>();
            Context.LoadStoredProc("getDeudoresByZona")
                .AddParam("@ZonaId", zonaid)
                .Exec(r => rows = r.ToList<Deudores>());
            return rows;

        }
    }
}
