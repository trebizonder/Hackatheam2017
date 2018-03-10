using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackatheam.Models
{
    public class PathList
    {
        private int _ID;
        private Path _FkPath;
        private List<User> _users = new List<User>();

        public PathList()
        {

        }
        public PathList(int ID, Path FkPath, List<User> users) 
        {
            _ID = ID;
            _FkPath = FkPath;
            _users = users;
        }
        public PathList(Path FkPath, List<User> users)
        {
            _FkPath = FkPath;
            _users = users;
        }
        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
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

        public List<User> users
        {
            get => _users;
            set
            {
                _users = value;
            }
        }

    }
}