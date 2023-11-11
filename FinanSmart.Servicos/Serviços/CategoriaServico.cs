using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.Interface.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Servicos.Serviços
{
    public class CategoriaServico : ICategoriaServico
    {
        IcategoriaRepository repository { get; set; }
        public CategoriaServico(IcategoriaRepository icategoriaRepository) { repository = icategoriaRepository; }
        public void AdicionarCategoria(Categoria categoria)
        {
            repository.AdicionarCategoria(categoria);
        }
    }
}
