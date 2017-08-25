using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinica_V3._0.Models
{
    public class Consulta
    {
        [Key]
        public int IDConsulta { get; set; }
        [Display(Name = "Plano de saude")]
        public string PlanoDeSaude { get; set; }
        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }
        [DisplayName("Paciente")]
        public int IDPaciente { get; set; }
        public virtual Paciente Paciente { get; set; }
        [ForeignKey("Medico")]
        public string IDMedico { get; set; }
        [DisplayName("Médico")]
        public virtual Medico Medico { get; set; }
    }
}