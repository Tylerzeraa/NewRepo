namespace FinanSmart.Dominio.Entities
{
    public class Gasto
	{
		public int GastoId { get; set; }
		public string Titulo { get; set; }
		public double Valor { get; set; }
		public DateTime Data { get; set; }
		public CategoriaGasto Categoria { get; set; }
	}

	public enum CategoriaGasto
	{
		Alimentacao,
		Transporte,
		Moradia,
		Saude,
		Lazer,
		Outros
	}
}
