using System;
namespace FinanSmart.Dominio.Entities
{


    public class Imposto
    {
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        // Construtor para inicializar os campos
        public Imposto(string tipo, decimal valor, DateTime dataVencimento)
        {
            Tipo = tipo;
            Valor = valor;
            DataVencimento = dataVencimento;
        }

        // Método para exibir informações do imposto
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Tipo de Imposto: {Tipo}");
            Console.WriteLine($"Valor do Imposto: {Valor:C}"); // Formata o valor como moeda
            Console.WriteLine($"Data de Vencimento: {DataVencimento:dd/MM/yyyy}");
        }
    }

}