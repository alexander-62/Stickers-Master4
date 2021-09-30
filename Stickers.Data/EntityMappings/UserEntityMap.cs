using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    public class UserEntityMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(DatabaseDefaults.FieldMaxLength).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(DatabaseDefaults.FieldMaxLength).IsRequired();
        }
    }
}
