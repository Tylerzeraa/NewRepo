using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.ValueObjects;
using Microsoft.EntityFrameworkCore;
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
        
        public async Task<List<Cadastro>> GetCadastros()
        {
            try
            {
                return await ctx.Cadastro.OrderBy(p => p.PrimeiroNome).ToListAsync();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }

        public void Excluir(string id)
        {
            Cadastro cadastro = ctx.Cadastro.FirstOrDefault(x => x.ID.ToString() == id);

            ctx.Cadastro.Remove(cadastro);
            ctx.SaveChanges();
        }

        public void AdicionarCadastro(Cadastro cadastro)
        {
            ctx.Cadastro.Add(cadastro);
            ctx.SaveChanges();
        }
    }
}

