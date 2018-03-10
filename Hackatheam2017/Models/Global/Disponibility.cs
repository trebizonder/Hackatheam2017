using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Disponibility
    {
        private int _ID;
        private DateTime _Date;
        private Path _FkPath;

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
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
        public Path FkPath
        {
            get => _FkPath;
            set
            {
                _FkPath = value;
            }
        }

    }
}