using FinanSmart.Dominio.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanSmart.Dados.EntityFramework
{
    public class CadastroConfiguration : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.ToTable("Cadastro", "FinanSmart");

            builder.HasKey(x => x.ID);

            builder
            .Property(p => p.ID)
            .HasColumnName("CadastroID")
            .HasColumnType("CHAR(36)");

            builder
            .Property(p => p.CPF)
            .HasColumnName("CadastroCPF")
            .HasColumnType("varchar(15)");

            builder
           .Property(p => p.Sobrenome)
           .HasColumnName("CadastroSobrenome")
           .HasColumnType("varchar(200)");
            
            builder
           .Property(p => p.PrimeiroNome)
           .HasColumnName("CadastroPrimeiroNome")
           .HasColumnType("varchar(200)");

            builder
            .Property(p => p.Email)
            .HasColumnName("CadastroEmail")
            .HasColumnType("varchar(200)");

            builder
           .Property(p => p.Senha)
           .HasColumnName("CadastroSenha")
           .HasColumnType("varchar(200)");
        }
    }
}
