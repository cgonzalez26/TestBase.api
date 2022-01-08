﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.InmueblesTitulares;

namespace TestBase.Api.Models.Titulares
{
    [Table("Titulares")]
    public class Titular : Base
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

        [JsonIgnore]
        public virtual ICollection<InmuebleTitular> InmueblesTitulares { get; set; } = new HashSet<InmuebleTitular>();
    }
}
