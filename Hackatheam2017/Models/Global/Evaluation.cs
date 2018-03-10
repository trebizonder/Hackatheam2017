using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class Evaluation
    {
        private int _ID;
        private User _FkDriver;
        private User _FkPassager;
        private Path _FkPath;
        private string _Note;
        private string _Description;

        public Evaluation()
        {

        }
        public Evaluation(int ID, User FkDriver, User FkPassager, string Note, string Description)
        {
            _ID = ID;
            _FkDriver = FkDriver;
            _FkPassager = FkPassager;
            _Note = Note;
            _Description = Description;

        }
        public Evaluation(User FkDriver, User FkPassager, string Note, string Description)
        {
            _FkDriver = FkDriver;
            _FkPassager = FkPassager;
            _Note = Note;
            _Description = Description;

        }
        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public User FkDriver
        {
            get => _FkDriver;
            set
            {
                _FkDriver = value;
            }
        }

        public User FkPassager
        {
            get => _FkPassager;
            set
            {
                _FkPassager = value;
            }
        }

        public string Note
        {
            get => _Note;
            set
            {
                _Note = value;
            }
        }

        public string Description
        {
            get => _Description;
            set
            {
                _Description = value;
            }
        }
    }
}