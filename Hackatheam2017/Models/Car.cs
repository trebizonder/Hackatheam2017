using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Car
    {
        private int _ID;
        private string _CarModel;
        private int _MaxPlace;

        public Car()
        {

        }

        public Car(int ID, string CarModel, int MaxPlace)
        {
            _ID = ID;
            _CarModel = CarModel;
            _MaxPlace = MaxPlace;
        }

        public Car(string CarModel, int MaxPlace)
        {
            _CarModel = CarModel;
            _MaxPlace = MaxPlace;
        }

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public string CarModel
        {
            get => _CarModel;
            set
            {
                _CarModel = value;
            }
        }

        public int MaxPlace
        {
            get => _MaxPlace;
            set
            {
                _MaxPlace = value;
            }
        }
    }
}