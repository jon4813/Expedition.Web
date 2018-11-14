using Expedition.Web.DAL.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expedition.Web.DAL.DbContext.EntitiesConfigurators
{
    public class CityConfigurator : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities", "dbo");

            builder.HasKey(city => city.Id);

            builder.HasOne(city => city.Country).WithMany(country => country.Cities)
                .HasForeignKey(city => city.CountryId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(city => city.Region).WithMany().HasForeignKey(city => city.RegionId);

            builder.Property<byte[]>("RowVersion").IsRowVersion();
            builder.Property<bool>("IsArchived");
            builder.HasQueryFilter(city => EF.Property<bool>(city, "IsArchived") == false);
        }
    }
}