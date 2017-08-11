using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCliniquinha.Models
{
    public class Paciente
    {
        public int IDPaciente { get; set; }
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Medico> ListaMedicos { get; set; }
    }
}