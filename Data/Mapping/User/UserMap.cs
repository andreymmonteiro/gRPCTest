using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.User
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.HasIndex(index => index.Document).IsUnique();
            builder.Property(prop => prop.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(prop => prop.CompanyOrPerson).IsRequired();
        }
    }
}
