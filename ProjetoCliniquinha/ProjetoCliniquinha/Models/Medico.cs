using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCliniquinha.Models
{
    public class Medico : Empregado
    {
        public int IDMedico { get; set; }
        public string Especialidades { get; set; }
        public List<Paciente> ListaPacientes { get; set; }
    }
}