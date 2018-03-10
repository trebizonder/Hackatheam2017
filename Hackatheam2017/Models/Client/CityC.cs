using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class CityC
    {
        [Required]
        public string CP { get; set; }
        [Required]
        public string Name { get; set; }
    }
}