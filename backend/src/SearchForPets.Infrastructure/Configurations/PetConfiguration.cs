using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.AnimalType).HasMaxLength(50);
            builder.Property(p => p.Breed).HasMaxLength(50);
            builder.Property(p => p.Color).HasMaxLength(50);
            builder.Property(p => p.Phone).HasMaxLength(13);
            builder.Property(p => p.Address).HasMaxLength(150);

            builder.HasMany(r => r.DetailsForHelp).WithOne();
            builder.HasMany(photo => photo.PetPhotos).WithOne();
        }
    }
}
