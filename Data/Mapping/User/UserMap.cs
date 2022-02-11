using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.User
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(pk => pk.id);
            builder.HasIndex(index => index.document).IsUnique();
            builder.Property(prop => prop.name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(prop => prop.companyOrPerson).IsRequired();
        }
    }
}
