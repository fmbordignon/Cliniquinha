using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace ProjetoCliniquinha.Models
{
    public class Administrador
    {
        [Key]
        public int IDAdmin { get; set; }
        [Required]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "RG")]
        public long RG { get; set; }
        [Display(Name = "Telefone")]

        [Required]
        public long Telefone { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Especialização")]
        public string Especializacao { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}