using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Minimundo.Domain.Entities.Authentication;

namespace Minimundo.Infra.Data.Mapping
{
    public class CredencialMap
    {
        public void Configure(EntityTypeBuilder<credencial> builder)
        {
            builder.ToTable("credencial");

            builder.HasKey(k => k.userApi);

            builder.Property(p => p.userApi)
                   .HasColumnName("userApi")
                   .HasColumnType("varchar")
                   .IsRequired()
                    .HasMaxLength(50);

            builder.Property(p => p.senha)
                .IsRequired()
                .HasColumnName("senha")
                .HasMaxLength(50);
        }
    }
}