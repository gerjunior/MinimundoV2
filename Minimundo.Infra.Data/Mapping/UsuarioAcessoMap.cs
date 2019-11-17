//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Minimundo.Domain.Entities;
//using Minimundo.Domain.Entities.Authentication;

//namespace Minimundo.Infra.Data.Mapping
//{
//    public class UsuarioAcessoMap : IEntityTypeConfiguration<UserToken>
//    {
//        public void Configure(EntityTypeBuilder<UserToken> builder)
//        {
//            builder.ToTable("UsuarioAcesso");

//            builder.HasKey(k => k.UserID);

//            builder.Property(p => p.UserID)
//                   .HasColumnName("UserID")
//                   .HasColumnType("int")
//                   .IsRequired();

//            builder.Property(p => p.AccessKey)
//                .IsRequired()
//                .HasColumnName("AccessKey")
//                .HasMaxLength(255);
//        }
//    }
//}