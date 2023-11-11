using FinanSmart.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface IcategoriaRepository
    {
        public void AdicionarCategoria(Categoria categoria); 
    }
}
