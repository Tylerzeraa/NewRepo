using FinanSmart.Dominio.ValueObjects;
using System;
namespace FinanSmart.Dominio.Entities
{

    namespace FinanSmart.WebApp.Controllers.Entidades
    {
        public class Pessoa
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string CPFCNPJ { get; set; }
            public Endereco Endereco { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Email { get; set; }
            public string ContaBancaria { get; set; }
            public DateTime DataNascimento { get; set; }
        }

    }
}