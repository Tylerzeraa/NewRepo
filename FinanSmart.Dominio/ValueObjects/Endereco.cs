using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.ValueObjects
{
    public class Endereco
    {
        public int ID { get; set; }
        public string Valor { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
    }
}

