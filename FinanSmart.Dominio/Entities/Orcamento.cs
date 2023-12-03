namespace FinanSmart.Dominio.Entities
{



    public class Orcamento
    {
        public int ID { get; set; }
        public int PessoaID { get; set; } // Referência à Pessoa por meio do ID
        public string Periodo { get; set; }
        public List<Categoria> CategoriasOrcamentarias { get; set; } // Lista de referências à Categoria
        public Dictionary<int, decimal> ValorPlanejadoPorCategoria { get; set; } // ID da Categoria -> Valor Planejado
        public Dictionary<int, decimal> ValorGastoRealPorCategoria { get; set; } // ID da Categoria -> Valor Gasto Real
    }
}