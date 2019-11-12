using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(k => k.EnderecoID);

            builder.Property(p => p.EnderecoID)
                   .HasColumnName(@"EnderecoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.UsuarioID)
                   .HasColumnName(@"UsuarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.CEP)
                   .HasColumnName(@"CEP")
                   .HasColumnType("char")
                   .HasMaxLength(8)
                   .IsRequired();

            builder.Property(p => p.Estado)
                   .HasColumnName(@"Estado")
                   .HasColumnType("char")
                   .HasMaxLength(2)
                   .IsRequired();

            builder.Property(p => p.Cidade)
                   .HasColumnName(@"Cidade")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Bairro)
                   .HasColumnName(@"Bairro")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Rua)
                   .HasColumnName(@"Rua")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Numero)
                   .HasColumnName(@"Numero")
                   .HasColumnType("varchar")
                   .HasMaxLength(10)
                   .IsRequired();

            builder.Property(p => p.Complemento)
                   .HasColumnName(@"Complemento")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.CriadoPor)
                  .HasColumnName(@"CriadoPor")
                  .HasColumnType("varchar")
                  .HasMaxLength(255)
                  .IsRequired();

            builder.Property(p => p.CriadoEm)
                   .HasColumnName(@"CriadoEm")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.ModificadoPor)
                   .HasColumnName("ModificadoPor")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.ModificadoEm)
                   .HasColumnName(@"ModificadoEm")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.Ativo)
                   .HasColumnName(@"Ativo")
                   .HasColumnType("bit")
                   .IsRequired();
        }
    }
}