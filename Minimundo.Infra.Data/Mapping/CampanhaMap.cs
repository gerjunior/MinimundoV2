using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class CampanhaMap : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.ToTable("Campanha");

            builder.HasKey(k => k.CampanhaID);

            builder.Property(p => p.CampanhaID)
                    .HasColumnName(@"CampanhaID")
                    .HasColumnType("int")
                    .IsRequired();

            builder.Property(p => p.EmpresaID)
                   .HasColumnName(@"EmpresaID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.AvaliadorID)
                   .HasColumnName(@"AvaliadorID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.Responsavel)
                   .HasColumnName(@"Responsavel")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName(@"Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Descricao)
                   .HasColumnName(@"Descricao")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.InicioPeriodo)
                   .HasColumnName(@"InicioPeriodo")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.FimPeriodo)
                   .HasColumnName(@"FimPeriodo")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.ValorPremio)
                   .HasColumnName(@"ValorPremio")
                   .HasColumnType("decimal(18,4)")
                   .IsRequired();

            builder.Property(p => p.Status)
                   .HasColumnName(@"Status")
                   .HasColumnType("char")
                   .HasMaxLength(1)
                   .IsRequired();
        }
    }
}