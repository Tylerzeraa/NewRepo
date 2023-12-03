using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;

namespace FinanSmart.Dados.Repositorios
{
    public class  CategoriaRepository : IcategoriaRepository
    {   
        Contexto ctx { get; set; }

        public CategoriaRepository(Contexto contexto) { 
            ctx = contexto;
        }
        public void AdicionarCategoria(Categoria categoria)
        {
            ctx.Categoria.Add(categoria);
            ctx.SaveChanges();
        }
    }
}
