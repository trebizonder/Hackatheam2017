using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Adress
    {
        private int _ID;
        private string _Number;
        private string _Street;
        private City _City;

        public Adress()
        {

        }

        public Adress(int ID, string Number, string Street, City city)
        {
            _ID = ID;
            _Number = Number;
            _Street = Street;
            _City = city;
        }

        public Adress(string Number, string Street, City city)
        {
            _Number = Number;
            _Street = Street;
            _City = city;
        }

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public string Number
        {
            get => _Number;
            set
            {
                _Number = value;
            }
        }

        public string Street
        {
            get => _Street;
            set
            {
                _Street = value;
            }
        }

        public City city
        {
            get => _City;
            set
            {
                _City = value;
            }
        }
    }
}