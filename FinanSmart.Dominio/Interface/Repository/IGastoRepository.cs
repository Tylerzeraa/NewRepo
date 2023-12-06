using FinanSmart.Dominio.Entities;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface IGastoRepository
    {
        void CadastrarGasto(Gasto gasto);
        void EditarGasto(Gasto gasto);
        void ExcluirGasto(Gasto gasto);
        List<Gasto> ListarGastos(string usuarioId);
        Gasto BuscarGasto(int id);
    }
}
