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
        [Display(Name = "Plano de saúde")]
        public string PlanoDeSaude { get; set; }
        [Display(Name = "Data da consulta")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }
        public int IDPaciente { get; set; }
        public int IDMedico { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }
    }
}