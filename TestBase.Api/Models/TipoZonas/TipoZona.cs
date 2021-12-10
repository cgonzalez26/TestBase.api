using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestBase.Api.Models.Zonas;
using Newtonsoft.Json;

namespace TestBase.Api.Models.TipoZonas
{
    [Table("TipoZonas")]
    public class TipoZona : Base
    {
        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(512)]
        public string Descripcion { get; set; }

        [JsonIgnore]
        public virtual ICollection<Zona> Zonas { get; set; } = new HashSet<Zona>();
    }
}
