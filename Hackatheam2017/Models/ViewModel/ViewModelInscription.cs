using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscription.Models
{
    public class ViewModelInscription
    {
        public IEnumerable<UserC> User { get; set; }
        public IEnumerable<CityC> City { get; set; }
        public IEnumerable<AdressC> Adress { get; set; }
        public IEnumerable<CarC> Car { get; set; }
    }
}