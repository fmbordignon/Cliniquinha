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
        [Required]
        [Display(Name = "Plano de saude")]
        public string PlanoDeSaude { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data da Consulta")]
        public DateTime DataConsulta { get; set; }
        [Required]
        [DisplayName("Paciente")]
        public int IDPaciente { get; set; }
        public virtual Paciente Paciente { get; set; }
        [Required]
        [DisplayName("Médico")]
        [ForeignKey("Medico")]
        public string IDMedico { get; set; }
        public virtual Medico Medico { get; set; }
        public bool Comparecimento { get; set; }
    }
}