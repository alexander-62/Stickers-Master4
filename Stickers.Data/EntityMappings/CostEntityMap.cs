using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Entities;

namespace Stickers.Data.EntityMappings
{
    public class CostEntityMap : IEntityTypeConfiguration<Cost>
    {
        public void Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.HasIndex(x => x.CostType).IsUnique();
        }
    }
}
