using FinanSmart.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
