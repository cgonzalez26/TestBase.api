using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestBase.Api.Models.TipoZonas
{
    public class TipoZonaConfiguration : IEntityTypeConfiguration<TipoZona>
    {
        public void Configure(EntityTypeBuilder<TipoZona> builder)
        {
            builder.HasQueryFilter(m => !m.IsDeleted);
        }
    }
}
