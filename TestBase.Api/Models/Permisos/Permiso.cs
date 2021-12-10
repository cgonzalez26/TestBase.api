using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestBase.Api.Models.RolPermisos;
using Newtonsoft.Json;

namespace TestBase.Api.Models.Permisos
{
    [Table("Permisos")]
    public class Permiso : Base
    {
        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(512)]
        public string Descripcion { get; set; }

        public int Orden { get; set; }

        [JsonIgnore]
        public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new HashSet<RolPermiso>();
    }
}
