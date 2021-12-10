﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBase.Api.Models.RolPermisos.Dtos
{
    public class RolPermisoWebDto : Base
    {
        [Required]
        [StringLength(64)]
        public string RolId { get; set; }

        [Required]
        [StringLength(64)]
        public string PermisoId { get; set; }
    }
}
