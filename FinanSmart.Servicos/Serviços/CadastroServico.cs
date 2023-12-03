using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.Interface.Serviços;
using FinanSmart.Dominio.ValueObjects;

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
