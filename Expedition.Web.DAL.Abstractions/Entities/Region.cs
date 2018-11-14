using System;

namespace Expedition.Web.DAL.Abstractions.Entities
{
    public class Region : Entity
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }
    }
}
