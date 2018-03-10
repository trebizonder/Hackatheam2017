using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class City
    {
        private int _ID;
        private string _CP;
        private string _Name;

        public City()
        {

        }
        public City(int ID, string CP, string Name)
        {
            _ID = ID;
            _CP = CP;
            _Name = Name;
        }

        public City(string CP, string Name)
        {
            _CP = CP;
            _Name = Name;
        }

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public string CP
        {
            get => _CP;
            set
            {
                _CP = value;
            }
        }

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
            }
        }
    }
}