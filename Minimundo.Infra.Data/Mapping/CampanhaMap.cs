using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;
using System;

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
                   .HasColumnType("varcahr")
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
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(p => p.FimPeriodo)
                   .HasColumnName(@"FimPeriodo")
                   .HasColumnType("datetime")
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
                   .HasColumnType("boolean")
                   .IsRequired();
        }
    }
    }
}