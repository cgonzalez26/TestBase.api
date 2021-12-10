﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestBase.Api.Models.Permisos;
using TestBase.Api.Models.Roles;
using Newtonsoft.Json;

namespace TestBase.Api.Models.RolPermisos
{
    [Table("RolPermisos")]
    public class RolPermiso : Base
    {
        [Required]
        [StringLength(64)]
        public string RolId { get; set; }

        [JsonIgnore]
        public virtual Rol Rol { get; set; }

        [Required]
        [StringLength(64)]
        public string PermisoId { get; set; }

        [JsonIgnore]
        public virtual Permiso Permiso { get; set; }
    }
}