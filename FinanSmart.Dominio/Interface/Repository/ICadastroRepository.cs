using FinanSmart.Dominio.ValueObjects;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface ICadastroRepository
    {
        public Cadastro GetCadastro(string id);
        public void Editar(Cadastro cadastro);
        public Task<List<Cadastro>> GetCadastros();
        public void Excluir(string id);
        public void AdicionarCadastro(Cadastro cadastro);
    }
}
