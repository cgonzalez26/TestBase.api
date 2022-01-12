using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Denuncias;

namespace TestBase.Api.Models.TipoDenuncias
{
    [Table("TipoDenuncias")]

    public class TipoDenuncia : Base
    {
        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }
      
        [StringLength(512)]
        public string Descripcion { get; set; }

        [JsonIgnore]
        public virtual ICollection<Denuncia> Denuncias { get; set; } = new HashSet<Denuncia>();
    }
}
