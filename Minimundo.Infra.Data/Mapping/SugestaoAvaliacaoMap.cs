using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

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
                   .HasColumnType("decimal(5,2)")
                   .IsRequired();

            builder.Property(p => p.Informacao)
                   .HasColumnName("Informacao")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}