using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinica_V3._0.Models
{
    public class Medico
    {
        [Key, ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public long Rg { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }
        public string Especilizacao { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}