using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class InscriptionC
    {
        [Required(ErrorMessage = "Prénom obligatoire")]
        [DataType(DataType.Text)]
        public int Firstname { get; set; }

        [Required(ErrorMessage = "Nom obligatoire")]
        [DataType(DataType.Text)]
        public int Lastname { get; set; }

        public string Sexe { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        //ADRESSE
        [Required]
        public string Number { get; set; }
        [Required]
        public string Street { get; set; }

        //CITY
        [Required]
        public string CP { get; set; }
        [Required]
        public string Name { get; set; }

        //VOITURE
        [Required]
        [DataType(DataType.Text)]
        public string CarModel { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int MaxPlace { get; set; }
        
    }
}