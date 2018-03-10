using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Path
    {
        private int _ID;
        private City _Depart;
        private City _Arrival;
        private User _Driver;

        public Path()
        {

        }
        public Path(int ID, City Depart, City Arrival, User Driver)
        {
            _ID = ID;
            _Depart = Depart;
            _Arrival = Arrival;
            _Driver = Driver;
        }

        public Path(City Depart, City Arrival, User Driver)
        {
            _Depart = Depart;
            _Arrival = Arrival;
            _Driver = Driver;
        }

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public City Depart
        {
            get => _Depart;
            set
            {
                _Depart = value;
            }
        }

        public City Arrival
        {
            get => _Arrival;
            set
            {
                _Arrival = value;
            }
        }

        public User Driver
        {
            get => _Driver;
            set
            {
                _Driver = value;
            }
        }

    }
}