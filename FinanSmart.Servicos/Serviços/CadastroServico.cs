using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.Interface.Serviços;
using FinanSmart.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Servicos.Serviços
{
    public class CadastroServico : ICadastroService
    {
        ICadastroRepository _repo;
        public CadastroServico(ICadastroRepository repo) { _repo = repo; }
        public void AdicionarCadastro(Cadastro cadastro)
        {
            cadastro.ID = Guid.NewGuid();
            _repo.AdicionarCadastro(cadastro);
        }
    }
}
