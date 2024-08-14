using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.VolunteerContext;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.FullName).HasMaxLength(150);
            builder.Property(v => v.Description).HasMaxLength(255);
            builder.Property(v => v.Phone).HasMaxLength(13);

            builder.HasMany(p => p.Pets).WithMany();
            builder.HasMany(sn => sn.SocialNetworks).WithMany();
            builder.HasMany(r => r.Requisites);
        }
    }
}
