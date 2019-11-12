using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;
using System;

namespace Minimundo.Infra.Data.Mapping
{
    public class CustoSugestaoMap : IEntityTypeConfiguration<CustoSugestao>
    {
        public void Configure(EntityTypeBuilder<CustoSugestao> builder)
        {
            builder.ToTable("CustoSugestao");

            builder.HasKey(k => k.CustoSugestaoID);

            builder.Property(p => p.CustoSugestaoID)
                   .HasColumnName(@"CustoSugestaoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.SugestaoID)
                   .HasColumnName(@"SugestaoID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.DescricaoCusto)
                   .HasColumnName(@"DescricaoCusto")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Valor)
                   .HasColumnName(@"Valor")
                   .HasColumnType("decimal")
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