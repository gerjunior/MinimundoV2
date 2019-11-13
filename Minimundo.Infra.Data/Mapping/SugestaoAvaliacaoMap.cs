using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;
using System;

namespace Minimundo.Infra.Data.Mapping
{
    public class SugestaoAvaliacaoMap : IEntityTypeConfiguration<SugestaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<SugestaoAvaliacao> builder)
        {
            builder.ToTable("SugestaoAvaliacao");

            builder.HasKey(k => k.SugestaoAvaliacaoID);

            builder.Property(p => p.SugestaoAvaliacaoID)
                   .HasColumnName("SugestaoAvaliacaoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.SugestaoID)
                   .HasColumnName("SugestaoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.Nota)
                   .HasColumnName("Nota")
                   .HasColumnType("decimal(14,4)")
                   .IsRequired();

            builder.Property(p => p.Informacao)
                   .HasColumnName("Informacao")
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