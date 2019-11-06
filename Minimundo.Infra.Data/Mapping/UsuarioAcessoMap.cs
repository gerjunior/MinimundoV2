using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class UsuarioAcessoMap : IEntityTypeConfiguration<UsuarioAcesso>
    {
        public void Configure(EntityTypeBuilder<UsuarioAcesso> obj)
        {
            obj.ToTable("UsuarioAcesso");

            obj.HasKey(k => k.UserID);

            obj.Property(p => p.AccessKey)
                .IsRequired()
                .HasColumnName("AccessKey")
                .HasMaxLength(255);
        }
    }
}
