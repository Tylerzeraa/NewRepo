using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.ValueObjects
{
    public class Telefone
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string CNPJ { get; set; }          
        public string Nome { get; set; }          
        public string Endereco { get; set; }   
        public string Cidade { get; set; }     
        public string Estado { get; set; }    
    }
}