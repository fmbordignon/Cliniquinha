using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoClinicaV2._0.Models
{
    public class Consulta
    {
        [Key]
        public int IDConsulta { get; set; }
        public string PlanoDeSaude { get; set; }
        public DateTime DataConsulta { get; set; }
        
    }
}