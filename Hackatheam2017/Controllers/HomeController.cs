using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolBox;

namespace Hackatheam2017.Controllers
{
    public class HomeController : Controller
    {
        private Connection _con;
        public HomeController()
        {
            _con = new Connection(Resource.Connection, DbProviderFactories.GetFactory("System.Data.SqlClient"));
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}