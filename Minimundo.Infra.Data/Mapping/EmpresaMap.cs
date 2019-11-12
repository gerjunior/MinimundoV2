using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(k => k.EmpresaID);

            builder.Property(p => p.EmpresaID)
                   .HasColumnName(@"EmpresaID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.NomeFantasia)
                   .HasColumnName(@"NomeFantasia")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.CNPJ)
                   .HasColumnName(@"CPNJ")
                   .HasColumnType("char")
                   .HasMaxLength(14)
                   .IsRequired();

            builder.Property(p => p.RazaoSocial)
                   .HasColumnName(@"RazaoSocial")
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
                   .HasColumnName(@"ModificadoPor")
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