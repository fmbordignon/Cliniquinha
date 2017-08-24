using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinica_V3._0.Models
{
    public class Medico
    {
        [Key]
        public int IDMedico { get; set; }
        public string Nome { get; set; }
    }
}