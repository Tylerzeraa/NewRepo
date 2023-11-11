using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Entities
{
    public class Usuario
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
