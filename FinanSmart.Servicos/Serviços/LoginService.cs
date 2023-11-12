using FinanSmart.Dados;
using FinanSmart.Dominio.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Servicos.Serviços
{
    public class LoginService : ILoginService
    {
        private readonly Contexto _contexto;

        public LoginService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool IsValid(string email, string password)
        {
            return _contexto.Cadastro.Any(x => x.Email == email && x.Senha == password);
        }
    }
}
