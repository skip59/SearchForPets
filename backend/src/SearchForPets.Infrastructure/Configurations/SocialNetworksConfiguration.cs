using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.VolunteerContext;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class SocialNetworksConfiguration : IEntityTypeConfiguration<SocialNetwork>
    {
        public void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            builder.HasKey(sn => sn.Id);
        }
    }
}
