﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models.Roles.Dtos;
using TestBase.Api.Models.Usuarios.Dtos;
using TestBase.Api.Services.Jwt;

namespace TestBase.Api.Models.Usuarios
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        public UsuarioWebDto Authenticate(string UsuarioNombre, string password, string secretKey, int expiresInDays)
        {
            var user = Context.Usuarios.Where(e => e.UsuarioNombre.Equals(UsuarioNombre)).Select(e => new UsuarioWebDto
            {
                Id = e.Id,
                UsuarioNombre = e.UsuarioNombre,
                Password = e.Password,
                Nombres = e.Nombres,
                Apellidos = e.Apellidos,
                FechaNacimiento = e.FechaNacimiento,
                Email = e.Email,
                Foto = e.Foto,
                CodigoPostal = e.CodigoPostal,
                Telefono = e.Telefono,
                RolId = e.RolId,
            }).FirstOrDefault();
            if (user == null) return null;
            //var passwordHasher = new PasswordHasher<UsuarioWebDto>();
            //var verifyHashedPassword = passwordHasher.VerifyHashedPassword(user, user.Password, password);
            //if (verifyHashedPassword != PasswordVerificationResult.Success)
            //{
            //    return null;
            //}
            var token = JwtService.Instance.GetToken(user, secretKey, expiresInDays);
            if (string.IsNullOrEmpty(token)) return null;
            user.Token = token;
            user.Password = null;
            /*user.Role = Context.Roles.Where(r => r.Id.Equals(user.RoleId)).Select(r => new RolWebDto
            {
                Id = r.Id,
                Nombre = r.Nombre,
                Descripcion = r.Descripcion,
                //IsAllPermissionsChecked = false,
            }).FirstOrDefault();*/
            return user;
        }
    }
}
