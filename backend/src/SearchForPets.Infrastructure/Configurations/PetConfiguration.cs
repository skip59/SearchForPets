using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.VolunteerContext.PetEntity;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pets");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasConversion(id => id.Value, value => PetId.Create(value));

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.AnimalType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Description)
                .HasMaxLength(500);

            builder.Property(p => p.Breed)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Color)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.BirthDay)
                .IsRequired();

            builder.Property(p => p.IsCastrated)
                .IsRequired();

            builder.Property(p => p.IsVaccinated)
                .IsRequired();

            builder.Property(p => p.HealthAbout)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.Color)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(p => p.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.ComplexProperty(p => p.AnthropometricIndicators, pa =>
            {
                pa.Property(x => x.Weight)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("weight");

                pa.Property(x => x.Growth)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("growth");
            });

            builder.ComplexProperty(p => p.Phone, pp =>
            {
                pp.Property(x => x.Number)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnName("phone");
            });

            builder.ComplexProperty(p => p.Address, pa =>
            {
                pa.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnName("city");

                pa.Property(x => x.Street)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("street");

                pa.Property(x => x.HouseNumber)
                .IsRequired()
                .HasMaxLength(6)
                .HasColumnName("house_number");

                pa.Property(x => x.FlatNumber)
                .IsRequired()
                .HasMaxLength(6)
                .HasColumnName("flat_number");
            });

            builder.OwnsOne(p => p.DetailsForHelp, pr =>
            {
                pr.ToJson("requisites");
                pr.OwnsMany(r => r.Requisites, pr =>
                {
                    pr.Property(x => x.Title)
                        .IsRequired()
                        .HasMaxLength(50);

                    pr.Property(x => x.Description)
                    .IsRequired()
                    .HasMaxLength(500);
                });
            });

            builder.OwnsOne(p => p.PhotosDetails, pp =>
            {
                pp.ToJson("pet_photos");
                pp.OwnsMany(ppd => ppd.PetPhotos, pd =>
                {
                    pd.Property(x => x.IsMain);
                    pd.Property(x => x.Path)
                    .IsRequired()
                    .HasMaxLength(500);
                });
            });
        }
    }
}
