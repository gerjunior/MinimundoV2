using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class UsuarioAcessoMap : IEntityTypeConfiguration<UsuarioAcesso>
    {
        public void Configure(EntityTypeBuilder<UsuarioAcesso> builder)
        {
            builder.ToTable("UsuarioAcesso");

            builder.HasKey(k => k.UserID);

            builder.Property(p => p.AccessKey)
                .IsRequired()
                .HasColumnName("AccessKey")
                .HasMaxLength(255);
        }
    }
}
