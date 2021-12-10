using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestBase.Api.Models.TipoEstablecimientos
{
    public class TipoEstablecimientoConfiguration : IEntityTypeConfiguration<TipoEstablecimiento>
    {
        public void Configure(EntityTypeBuilder<TipoEstablecimiento> builder)
        {
            builder.HasQueryFilter(m => !m.IsDeleted);
        }
    }
}
