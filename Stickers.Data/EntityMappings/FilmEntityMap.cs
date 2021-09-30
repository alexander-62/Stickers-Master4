using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stickers.Data.Model.Constants;
using Film = Stickers.Data.Entities.Film;

namespace Stickers.Data.EntityMappings
{
    public class FilmEntityMap : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(p => p.Name)
                .HasMaxLength(DatabaseDefaults.FieldMaxLength)
                .IsRequired();
        }
    }
}
