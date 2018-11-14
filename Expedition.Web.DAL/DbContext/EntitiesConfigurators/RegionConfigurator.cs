using Expedition.Web.DAL.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expedition.Web.DAL.DbContext.EntitiesConfigurators
{
    internal class RegionConfigurator : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Regions", "dbo");
            builder.HasKey(region => region.Id);

            builder.Property<byte[]>("RowVersion").IsRowVersion();
            builder.Property<bool>("IsArchived");
            builder.HasQueryFilter(city => EF.Property<bool>(city, "IsArchived") == false);
        }
    }
}