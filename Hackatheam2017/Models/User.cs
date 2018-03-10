using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class User
    {
        private int _ID;
        private string _Firstname;
        private string _Lastname;
        private string _Sexe;
        private string _Mail;
        private string _Password;
        private Adress _Fk_Address;
        private Car _Fk_Voiture;

        public User()
        {

        }

        public User(int ID, string Firstname, string Lastname, string Sexe, string Mail, string Password, Adress FkAdress, Car FkCar)
        {
            _ID = ID;
            _Firstname = Firstname;
            _Lastname = Lastname;
            _Sexe = Sexe;
            _Mail = Mail;
            _Password = Password;
            _Fk_Address = FkAdress;
            _Fk_Voiture = FkCar;
        }

        public User(string Firstname, string Lastname, string Sexe, string Mail, string Password, Adress FkAdress, Car FkCar)
        {
            _Firstname = Firstname;
            _Lastname = Lastname;
            _Sexe = Sexe;
            _Mail = Mail;
            _Password = Password;
            _Fk_Address = FkAdress;
            _Fk_Voiture = FkCar;
        }

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public string Firstname
        {
            get => _Firstname;
            set
            {
                _Firstname = value;
            }
        }

        public string Lastname
        {
            get => _Lastname;
            set
            {
                _Lastname = value;
            }
        }

        public string Sexe
        {
            get => _Sexe;
            set
            {
                _Sexe = value;
            }
        }

        public string Mail
        {
            get => _Mail;
            set
            {
                _Mail = value;
            }
        }

        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
            }
        }

        public Adress Fk_Address
        {
            get => _Fk_Address;
            set
            {
                _Fk_Address = value;
            }
        }

        public Car Fk_Voiture
        {
            get => _Fk_Voiture;
            set
            {
                _Fk_Voiture = value;
            }
        }
    }
}