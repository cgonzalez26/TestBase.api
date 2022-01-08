using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.Titulares.Dtos
{
    public class TitularWebDto : Base
    {
        [Required]
        [StringLength(50)]
        public string sNombre { get; set; }

        [StringLength(50)]
        public string sApellido { get; set; }

        [StringLength(1024)]
        public string sDomicilio { get; set; }

        [StringLength(50)]
        public string sTelefono { get; set; }

        [StringLength(50)]
        public string sCelular { get; set; }

        [StringLength(128)]
        public string sMail { get; set; }
    }
}
