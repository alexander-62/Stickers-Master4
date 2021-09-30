using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.EntityMappings
{
    public class RollEntityMap : IEntityTypeConfiguration<Roll>
    {
        public void Configure(EntityTypeBuilder<Roll> builder)
        {
            builder.Property(x => x.Manufacturer).HasMaxLength(DatabaseDefaults.FieldMaxLength).IsRequired();
            builder.HasOne(p => p.Film)
                .WithMany(x => x.Rolls)
                .HasForeignKey(p => p.FilmId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
