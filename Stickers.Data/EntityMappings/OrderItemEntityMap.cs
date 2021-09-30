using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    public class OrderItemEntityMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.Property(p => p.CommentForDesigner)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.Name)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.CommentForProduction)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.Property(p => p.CuttingLength)
                .HasColumnType("decimal(18,4)");
            builder.HasOne(p => p.Order)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Film)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.FilmId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
