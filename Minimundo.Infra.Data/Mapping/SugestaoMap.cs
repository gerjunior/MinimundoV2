using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

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
        }
    }
}