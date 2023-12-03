using FinanSmart.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dados.EntityFramework
{
    internal class GastoConfiguration : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Gasto> builder)
        {
            builder.ToTable("Gasto", "FinanSmart");

            builder.HasKey(x => x.GastoId);

            builder
            .Property(p => p.GastoId)
            .HasColumnName("GastoId")
            .HasColumnType("int");

            builder
            .Property(p => p.Titulo)
            .HasColumnName("Titulo")
            .HasColumnType("varchar(200)");

            builder
            .Property(p => p.Valor)
            .HasColumnName("Valor")
            .HasColumnType("decimal(18,2)");

            builder
            .Property(p => p.Data)
            .HasColumnName("Data")
            .HasColumnType("datetime");

            builder
            .Property(p => p.Categoria)
            .HasColumnName("Categoria")
            .HasColumnType("int");
        }
    }
}
