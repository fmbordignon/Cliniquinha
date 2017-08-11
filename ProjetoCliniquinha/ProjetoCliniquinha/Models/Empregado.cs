using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCliniquinha.Models
{
    public abstract class Empregado
    {
        public string Nome { get; set; }
        public long RG { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}