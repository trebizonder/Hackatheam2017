using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class UserC
    {
        private int _ID;
        private string _Firstname;
        private string _Lastname;
        private string _Sexe;
        private string _Mail;
        private string _Password;
        private AdressC _Fk_Address;
        private CarC _Fk_Voiture;

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
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public AdressC Fk_Adress { get; set; }

        [Required]
        public CarC Fk_Voiture { get; set; }

    }
}