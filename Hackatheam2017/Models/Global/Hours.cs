using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Hours
    {
        private int _ID;
        private Disponibility _FkDispo;
        private DateTime _Date;
        private TimeSpan _HourDeparture;
        private TimeSpan _HourArrival;

        public Hours()
        {

        }
        public Hours(int ID, Disponibility FkDispo, DateTime Date, TimeSpan HourDeparture,TimeSpan Arrival)
        {
            _ID = ID;
            _FkDispo = FkDispo;
            _Date = Date;
            _HourDeparture = HourDeparture;
            _HourArrival = HourArrival;
        }
        public Hours(Disponibility FkDispo, DateTime Date, TimeSpan HourDeparture, TimeSpan Arrival)
        {
            _FkDispo = FkDispo;
            _Date = Date;
            _HourDeparture = HourDeparture;
            _HourArrival = HourArrival;
        }
        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public Disponibility FkDispo
        {
            get => _FkDispo;
            set
            {
                _FkDispo = value;
            }
        }

        public DateTime Date
        {
            get => _Date;
            set
            {
                _Date = value;
            }
        }

        public TimeSpan HourDeparture
        {
            get => _HourDeparture;
            set => _HourDeparture = value;            
        }

        public TimeSpan HourArrival
        {
            get => _HourArrival;
            set => _HourArrival = value;
        }

    }
}