using FinanSmart.Dados.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanSmart.Dominio.Entities;
using Microsoft.Extensions.Options;
using FinanSmart.Dominio.ValueObjects;

namespace FinanSmart.Dados
{
    public class Contexto : DbContext

    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"data source = 201.62.57.93,1434;
                                        Database = BD043413;
                                        User ID = RA043413;
                                        Password = 043413;
                                        TrustServerCertificate = True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new CadastroConfiguration());
        }

    }
}

