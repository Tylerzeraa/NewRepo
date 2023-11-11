namespace FinanSmart.Dominio.Entities
{
    public class TransacaoFinanceira
    {
        public string TipoTransacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public ContaBancaria ContaEnvolvida { get; set; }
    }
}