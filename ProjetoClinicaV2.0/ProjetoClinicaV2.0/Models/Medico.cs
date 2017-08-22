using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoClinicaV2._0.Models
{
    public class Medico
    {
        [Key]
        public int IDMedico { get; set; }
        public string Especilizacao { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
    }
}