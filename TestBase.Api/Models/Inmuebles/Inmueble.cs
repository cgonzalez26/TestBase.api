using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.ImpuestosInm;
using TestBase.Api.Models.InmueblesTitulares;

namespace TestBase.Api.Models.Inmuebles
{
    [Table("Inmuebles")]
    public class Inmueble : Base
    {
        [StringLength(50)]
        public string sZona { get; set; }

        [StringLength(50)]
        public string sTerreno { get; set; }

        public double nVal_Ed { get; set; }
        public double nVal_Fis { get; set; }

        [StringLength(255)]
        public string sDomicilio { get; set; }

        public int iPIN { get; set; }

        [JsonIgnore]
        public virtual ICollection<ImpuestoInm> ImpuestosInm { get; set; } = new HashSet<ImpuestoInm>();

        [JsonIgnore]
        public virtual ICollection<InmuebleTitular> InmueblesTitulares { get; set; } = new HashSet<InmuebleTitular>();
    }
}
