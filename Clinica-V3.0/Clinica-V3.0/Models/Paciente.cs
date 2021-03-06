﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica_V3._0.Models
{
    public class Paciente
    {
        [Key]
        public int IDPaciente { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Telefone")]
        [Required]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DataNascimento { get; set; }
        public List<Consulta> ListaConsultas { get; set; }
    }
}