using System;
using System.ComponentModel.DataAnnotations;

namespace Expedition.Web.DAL.Abstractions.Entities
{
    public class Partners
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
