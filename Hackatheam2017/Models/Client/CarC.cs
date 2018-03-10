using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class CarC
    {
        [Required]
        [DataType(DataType.Text)]
        public string CarModel { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int MaxPlace { get; set; }
    }
}