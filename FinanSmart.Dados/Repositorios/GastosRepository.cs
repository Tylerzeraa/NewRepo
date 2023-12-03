using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;

namespace FinanSmart.Dados.Repositorios
{
    public class GastosRepository : IGastoRepository
    {
        Contexto ctx;
        public GastosRepository(Contexto contexto)
        {
            ctx = contexto;
        }

        public Gasto BuscarGasto(int id)
        {
            return ctx.Gasto.Find(id);
        }

        public void CadastrarGasto(Gasto gasto)
        {
            ctx.Gasto.Add(gasto);
            ctx.SaveChanges();
        }

        public void EditarGasto(Gasto gasto)
        {
            ctx.Gasto.Update(gasto);
            ctx.SaveChanges();
        }

        public void ExcluirGasto(Gasto gasto)
        {
            ctx.Gasto.Remove(gasto);
            ctx.SaveChanges();
        }

        public List<Gasto> ListarGastos()
        {
            return ctx.Gasto.ToList();
        }
    }
}
