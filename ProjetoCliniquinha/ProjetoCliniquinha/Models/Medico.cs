using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCliniquinha.Models
{
    public class Medico : ApplicationUser
    {
        [Key]
        public int IDMedico { get; set; }
        public string Nome { get; set; }
        public long RG { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Especialidades { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
    }

}