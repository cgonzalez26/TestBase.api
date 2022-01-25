using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.VehiculosTitulares;

namespace TestBase.Api.Models.Vehiculos
{
    [Table("Vehiculos")]
    public class Vehiculo : Base
    {
        [StringLength(50)]
        public string sModelo { get; set; }

        [StringLength(50)]
        public string sMarca { get; set; }

        public int iAnio { get; set; }

        public double nVal_F_V { get; set; }

        [StringLength(255)]
        public string sDomicilio { get; set; }

        public int iPIN { get; set; }

        [JsonIgnore]
        public virtual ICollection<VehiculoTitular> VehiculosTitulares { get; set; } = new HashSet<VehiculoTitular>();
    }
}
