using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    public class SpecieConfiguration : IEntityTypeConfiguration<Specie>
    {
        public void Configure(EntityTypeBuilder<Specie> builder)
        {
            builder.ToTable("specie");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasConversion(id => id.Value, value => SpecieId.Create(value));

            builder.ComplexProperty(v => v.Title, sb =>
            {
                sb.Property(x => x.Value)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("title");
            });

            builder.HasMany(b => b.Breeds).WithOne();
        }
    }
}
