using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(k => k.UsuarioID);

            builder.Property(p => p.UsuarioID)
                   .HasColumnName("UsuarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasColumnName("Email")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.Senha)
                   .HasColumnName("Senha")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Nome)
                   .HasColumnName("Nome")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.CPF)
                   .HasColumnName("CPF")
                   .HasColumnType("char")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(p => p.Sexo)
                   .HasColumnName("Sexo")
                   .HasColumnType("char")
                   .HasMaxLength(1)
                   .IsRequired();
        }
    }
}