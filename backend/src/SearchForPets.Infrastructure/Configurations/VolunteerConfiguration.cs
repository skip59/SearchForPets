﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable("volunteers");
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .HasConversion(id => id.Value, value => VolunteerId.Create(value));
           
            builder.Property(v => v.Description)
                .HasMaxLength(500);

            builder.Property(v => v.YearsOfExperience)
                .IsRequired();

            builder.ComplexProperty(v => v.FullName, vn =>
            {
                vn.Property(x => x.Firstname)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("first_name");
                vn.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("last_name");
                vn.Property(x => x.SecondName)
                .IsRequired(false)
                .HasMaxLength(20)
                .HasColumnName("second_name");
            });

            builder.ComplexProperty(v => v.Phone, vp =>
            {
                vp.Property(x => x.Number)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnName("phone");
            });

            builder.OwnsOne(v => v.Requisites, vr =>
            {
                vr.ToJson("requisites");
                vr.OwnsMany(vrd => vrd.Requisites, vrb =>
                {
                    vrb.Property(r => r.Title)
                    .IsRequired()
                    .HasMaxLength(30);
                    vrb.Property(r => r.Description)
                    .IsRequired()
                    .HasMaxLength(500);
                });
            });

            builder.OwnsOne(v => v.SocialNetworks, vb =>
            {
                vb.ToJson("social_networks");

                vb.OwnsMany(vs => vs.SocialNetworks, vsb =>
                {
                    vsb.Property(t=>t.Title)
                        .IsRequired()
                        .HasMaxLength(50);

                    vsb.Property(r => r.Url)
                    .IsRequired()
                    .HasMaxLength(500);

                });
            });

            builder.HasMany(p => p.Pets).WithOne();
        }
    }
}
