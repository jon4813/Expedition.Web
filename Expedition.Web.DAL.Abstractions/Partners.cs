using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Expedition.Web.DAL.DbContext.Entities
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
