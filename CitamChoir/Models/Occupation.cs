using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CitamChoir.Models
{
    public class Occupation
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}