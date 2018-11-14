using System;

namespace Expedition.Web.DAL.Abstractions.Entities
{
    public class City : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Guid? RegionId { get; set; }
        public Guid CountryId { get; set; }

        public Region Region { get; set; }
        public Country Country { get; set; }
    }
}