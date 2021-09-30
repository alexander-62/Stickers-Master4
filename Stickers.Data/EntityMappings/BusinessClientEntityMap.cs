using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    public class BusinessClientEntityMap : IEntityTypeConfiguration<BusinessClient>
    {
        public void Configure(EntityTypeBuilder<BusinessClient> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength)
                .IsRequired();
            builder.Property(p => p.VkId)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.Address)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.PostIndex)
                .HasMaxLength(6);
            builder.Property(p => p.ReceiverCredentials)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.Comment)
                 .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.VkLink)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.VkGroupName)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);

        }
    }
}
