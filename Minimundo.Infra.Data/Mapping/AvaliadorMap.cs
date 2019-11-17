using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

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
        }
    }
}