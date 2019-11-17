using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

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
                   .HasColumnType("decimal(18,4)")
                   .IsRequired();
        }
    }
}