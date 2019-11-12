using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;
using System;

namespace Minimundo.Infra.Data.Mapping
{
    public class AvaliadorMap : IEntityTypeConfiguration<Avaliador>
    {
        public void Configure(EntityTypeBuilder<Avaliador> builder)
        {
            builder.ToTable("Avaliador");

            builder.HasKey(k => k.AvaliadorID);

            builder.Property(p => p.AvaliadorID)
                    .HasColumnName(@"AvaliadorID")
                    .HasColumnType("int")
                    .IsRequired();

            builder.Property(p => p.UsuarioID)
                   .HasColumnName(@"UsuarioID")
                   .HasColumnType("int")
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