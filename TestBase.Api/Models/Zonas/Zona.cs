using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestBase.Api.Models.TipoZonas;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;
using TestBase.Api.Models.Establecimientos;
using System.Collections.Generic;
using TestBase.Api.Models.Inmuebles;
using TestBase.Api.Models.Titulares;

namespace TestBase.Api.Models.Zonas
{
    [Table("Zonas")]
    public class Zona : Base
    {
        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }

        [StringLength(64)]
        public string PadreId { get; set; }

        [JsonIgnore]
        public virtual Zona Padre { get; set; }

        public Geometry Geometria { get; set; }

        [Required]
        [StringLength(1024)]
        public string FullId { get; set; }

        [StringLength(64)]
        public string TipoZonaId { get; set; }

        [JsonIgnore]
        public virtual TipoZona TipoZona { get; set; }

        [JsonIgnore]
        public virtual ICollection<Establecimiento> Establecimientos { get; set; } = new HashSet<Establecimiento>();

        [JsonIgnore]
        public virtual ICollection<Inmueble> Inmuebles { get; set; } = new HashSet<Inmueble>();

        [JsonIgnore]
        public virtual ICollection<Titular> Titulares { get; set; } = new HashSet<Titular>();
    }
}
