using Expedition.Web.DAL.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expedition.Web.DAL.DbContext.EntitiesConfigurators
{
    internal class CountryConfigurator : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries", "dbo");

            builder.HasKey(country => country.Id);

            builder.Property<byte[]>("RowVersion").IsRowVersion();
            builder.Property<bool>("IsArchived");
            builder.HasQueryFilter(city => EF.Property<bool>(city, "IsArchived") == false);
        }
    }
}