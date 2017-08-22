using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoClinicaV2._0.Models
{
    public class Paciente
    {
        [Key]
        public int IDPaciente { get; set; }
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
    }
}