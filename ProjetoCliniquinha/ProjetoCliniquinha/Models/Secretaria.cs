using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCliniquinha.Models
{
    public class Secretaria : ApplicationUser
    {
        public int IDSecretaria { get; set; }
        public string Nome { get; set; }
        public long RG { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
    }
}