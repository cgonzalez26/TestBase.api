using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Titulares;
using TestBase.Api.Models.Vehiculos;

namespace TestBase.Api.Models.VehiculosTitulares.Dtos
{
    public class VehiculoTitularWebDto : Base
    {
        [StringLength(64)]
        public string VehiculoId { get; set; }

        [JsonIgnore]
        public virtual Vehiculo Vehiculo { get; set; }

        [StringLength(64)]
        public string TitularId { get; set; }

        [JsonIgnore]
        public virtual Titular Titular { get; set; }
    }
}
