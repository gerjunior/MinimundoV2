using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefone");

            builder.HasKey(k => k.TelefoneID);

            builder.Property(p => p.TelefoneID)
                   .HasColumnName("TelefoneID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.UsuarioID)
                   .HasColumnName("UsuarioID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.Tipo)
                   .HasColumnName("Tipo")
                   .HasColumnType("char")
                   .HasMaxLength(1)
                   .IsRequired();

            builder.Property(p => p.DDD)
                   .HasColumnName("DDD")
                   .HasColumnType("varchar")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(p => p.DDI)
                   .HasColumnName("DDI")
                   .HasColumnType("varchar")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(p => p.Numero)
                   .HasColumnName("Numero")
                   .HasColumnType("varchar")
                   .HasMaxLength(4)
                   .IsRequired();
        }
    }
}