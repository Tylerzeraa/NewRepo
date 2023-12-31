﻿using FinanSmart.Dados;
using FinanSmart.Dominio.Interface.Repository;

namespace FinanSmart.Servicos.Serviços
{
    public class LoginService : ILoginService
    {
        private readonly Contexto _contexto;

        public LoginService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Guid GetId(string email)
        {
            return _contexto.Cadastro.FirstOrDefault(x => x.Email == email)!.ID;
        }

        public bool IsValid(string email, string password)
        {
            return _contexto.Cadastro.Any(x => x.Email == email && x.Senha == password);
        }
    }
}
