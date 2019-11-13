using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;
using System;

namespace Minimundo.Infra.Data.Mapping
{
    public class SugestaoMap : IEntityTypeConfiguration<Sugestao>
    {
        public void Configure(EntityTypeBuilder<Sugestao> builder)
        {
            builder.ToTable("Sugestao");

            builder.HasKey(k => k.SugestaoID);

            builder.Property(p => p.SugestaoID)
                   .HasColumnName("SugestaoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.CampanhaID)
                   .HasColumnName("CampanhaID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.FuncionarioID)
                   .HasColumnName("FuncionarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.Descricao)
                   .HasColumnName("Descricao")
                   .HasColumnType("varchar")
                   .HasMaxLength(500)
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