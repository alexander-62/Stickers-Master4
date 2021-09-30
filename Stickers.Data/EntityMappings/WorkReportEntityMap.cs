using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    class WorkReportEntityMap : IEntityTypeConfiguration<WorkReport>
    {
        public void Configure(EntityTypeBuilder<WorkReport> builder)
        {
            builder.HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Property(p => p.PlotteringLength)
                .HasColumnType("decimal(18,4)");
            builder.Property(p => p.PaperParameters).HasMaxLength(DatabaseDefaults.FieldMaxLength);
            builder.HasOne(p => p.OrderItem)
                .WithMany(p => p.WorkReports)
                .HasForeignKey(p => p.OrderItemId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(p => p.Roll)
                .WithMany()
                .HasForeignKey(p => p.RollId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
