using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class AdressC
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public CityC City { get; set; }
    }
}