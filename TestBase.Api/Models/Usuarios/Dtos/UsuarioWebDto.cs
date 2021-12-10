﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Attributes;
using TestBase.Api.Models.Roles;

namespace TestBase.Api.Models.Usuarios.Dtos
{
    public class UsuarioWebDto : Base
    {
        [Required]
        [StringLength(64)]
        public string UsuarioNombre { get; set; }

        [Required]
        [StringLength(1024)]
        [JsonIgnore]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(64)]
        public string Apellidos { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(64)]
        public string Email { get; set; }

        [StringLength(1024)]
        public string Foto { get; set; }

        [StringLength(8)]
        public string CodigoPostal { get; set; }

        [StringLength(16)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(64)]
        public string RolId { get; set; }

        [JsonIgnore]
        public virtual Rol Rol { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}
