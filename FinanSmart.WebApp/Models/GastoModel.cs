using FinanSmart.Dominio.Entities;

namespace FinanSmart.WebApp.Models
{
    public class GastoModel
	{
        public int GastoId { get; set; }
        public string Titulo { get; set; }
		public double Valor { get; set; }
		public DateTime Data { get; set; }
		public CategoriaGasto Categoria { get; set; }
	}
}
