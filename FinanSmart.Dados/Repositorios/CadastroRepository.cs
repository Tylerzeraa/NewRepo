using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dados.Repositorios
{
    public class CadastroRepository : ICadastroRepository
    {
        Contexto ctx { get; set; }

        public CadastroRepository(Contexto contexto)
        {
            ctx = contexto;
        }
        public void AdicionarCadastro(Cadastro cadastro)
        {
            ctx.Cadastro.Add(cadastro);
            ctx.SaveChanges();
        }
    }
}

