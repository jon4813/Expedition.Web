using System.Collections.Generic;

namespace Expedition.Web.DAL.Abstractions.Entities
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}