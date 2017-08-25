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
        [Key, ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public string Nome { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}