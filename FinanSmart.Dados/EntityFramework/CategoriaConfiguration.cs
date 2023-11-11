using FinanSmart.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dados.EntityFramework
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria" , "FinanSmart");

            builder.HasKey(x => x.CategoriaID);

            builder
            .Property(p => p.CategoriaID)
            .HasColumnName("CategoriaID")
            .HasColumnType("int");

            builder
            .Property(p => p.CategoriaNome)
            .HasColumnName("CategoriaNome")
            .HasColumnType("varchar(200)");

            builder
           .Property(p => p.CategoriaDescricao)
           .HasColumnName("CategoriaDescricao")
           .HasColumnType("varchar(200)");

        }
    }
}
