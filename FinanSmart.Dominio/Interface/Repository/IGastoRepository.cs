using FinanSmart.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface IGastoRepository
    {
        void CadastrarGasto(Gasto gasto);
        void EditarGasto(Gasto gasto);
        void ExcluirGasto(Gasto gasto);
        List<Gasto> ListarGastos();
        Gasto BuscarGasto(int id);
    }
}
