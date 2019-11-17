using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(k => k.FuncionarioID);

            builder.Property(p => p.FuncionarioID)
                   .HasColumnName("FuncionarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.UsuarioID)
                   .HasColumnName("UsuarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.EmpresaID)
                   .HasColumnName("EmpresaID")
                   .HasColumnType("int")
                   .IsRequired();
        }
    }
}