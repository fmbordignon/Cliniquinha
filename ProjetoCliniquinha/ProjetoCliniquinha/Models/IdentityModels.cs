﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoCliniquinha.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }
        // Add custom user claims here
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "RG")]
        public long RG { get; set; }
        [Display(Name = "Telefone")]
        public long Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Especialização")]
        public string Especializacao { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext()
    //        : base("DefaultConnection", throwIfV1Schema: false)
    //    {
    //    }

    //    public static ApplicationDbContext Create()
    //    {
    //        DbSet<Medico> medicos = 
    //        return new ApplicationDbContext();
    //    }
}
}