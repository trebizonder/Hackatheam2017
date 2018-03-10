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
        private string _SqlAuthConnectionString;
        private Connection _con;
        public HomeController()
        {
            _SqlAuthConnectionString = @"Server=FLORLIFE;" +
                                       "Database=naveDb;" +
                                       "User Id=sa;Password=tftic@2012";
            _con = new Connection(_SqlAuthConnectionString, DbProviderFactories.GetFactory("System.Data.SqlClient"));
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}