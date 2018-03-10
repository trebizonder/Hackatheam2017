using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hackatheam2017.Models.Form
{
    public class Search
    {
        [Required]
        public string DepartureCity { get; set; }
        [Required]
        public string ArrivalCity { get; set; }
        [Required]
        public string DepartureHour { get; set; }
        [Required]
        public string ArrivalHour { get; set; }

    }
}