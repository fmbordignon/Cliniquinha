﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Clinica_V3._0.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public virtual Medico Medico { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public virtual Administrador Administrador { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Medico> Medico { get; set; }
        public DbSet<Secretaria> Secretaria { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
}