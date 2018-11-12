using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions;
using Expedition.Web.DAL.Abstractions.DbContext;
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
        }
    }
}