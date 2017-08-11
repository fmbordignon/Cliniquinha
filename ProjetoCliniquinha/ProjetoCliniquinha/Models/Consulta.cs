using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCliniquinha.Models
{
    public class Consulta
    {
        public int IDConsulta { get; set; }
        public string PlanoDeSaude { get; set; }
        public DateTime DataConsulta { get; set; }
        public int IDPaciente { get; set; }
        public int IDMedico { get; set; }
    }
}