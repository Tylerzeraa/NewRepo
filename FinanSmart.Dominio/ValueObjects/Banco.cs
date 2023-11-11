using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.ValueObjects
{
    public class Banco
    {
        public int ID { get; set; }          
        public string Nome { get; set; }     
        public string CNPJ { get; set; }   
        public string Endereco { get; set; }   
        public string Cidade { get; set; }     
        public string Estado { get; set; }    
        public string Telefone { get; set; }  
    }

}