using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    public class OrderEntityMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.TrackIdentifier)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.Comment)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.DeliveryAddress)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.PostIndex)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.ReceiverCredentials)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.InsertedBy)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);


            builder.HasOne(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
