using Expedition.Web.DAL.Abstractions.Entities;
using Expedition.Web.DAL.DbContext.EntitiesConfigurators;
using Microsoft.EntityFrameworkCore;

namespace Expedition.Web.DAL.DbContext
{
    public class ExpeditionDbContex : Microsoft.EntityFrameworkCore.DbContext
    {
        public ExpeditionDbContex(DbContextOptions<ExpeditionDbContex> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfigurator());
            modelBuilder.ApplyConfiguration(new RegionConfigurator());
            modelBuilder.ApplyConfiguration(new CountryConfigurator());
        }
    }
}