using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.SpeciesContext.BreedEntity;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.ToTable("breed");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .HasConversion(id => id.Value, value => BreedId.Create(value));

            builder.ComplexProperty(b => b.Title, vp =>
            {
                vp.Property(x => x.Value)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnName("title");
            });
        }
    }
}
