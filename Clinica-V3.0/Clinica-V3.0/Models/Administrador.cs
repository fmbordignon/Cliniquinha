using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinica_V3._0.Models
{
    public class Administrador
    {
        [Key, ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public long Rg { get; set; }
        [Required]
        [Display(Name = "Telefone/Celular")]
        public string Telefone { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}