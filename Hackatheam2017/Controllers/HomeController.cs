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
            _SqlAuthConnectionString = @"Server=tcp:navetteurserver.database.windows.net,1433;Initial Catalog=navDb;Persist Security Info=False;User ID={trebizonder};Password={tftic@2018};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            _con = new Connection(_SqlAuthConnectionString, DbProviderFactories.GetFactory("System.Data.SqlClient"));
        }

        public ActionResult Index()
        {
            Command cmd = new Command("SELECT Name FROM City WHERE PostalCode=6041");

            ViewBag.CP = (string)_con.ExecuteScalar(cmd);
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