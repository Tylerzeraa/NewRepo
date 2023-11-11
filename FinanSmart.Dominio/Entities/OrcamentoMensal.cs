
namespace FinanSmart.Dominio.Entities
{
    public class OrcamentoMensal
    {
        public string Mes { get; set; }
        public List<DespesaPlanejada> DespesasPlanejadas { get; set; }
        public List<ReceitaEsperada> ReceitasEsperadas { get; set; }
    }
    public class DespesaPlanejada
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }

    public class ReceitaEsperada
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}