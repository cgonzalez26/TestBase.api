using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.VehiculosTitulares.Dtos
{
    public class VehiculoTitularWebDto : Base
    {
        [StringLength(64)]
        public string VehiculoId { get; set; }
       
        [StringLength(64)]
        public string TitularId { get; set; }

    }
}
