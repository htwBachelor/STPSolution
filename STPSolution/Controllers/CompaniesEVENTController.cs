using STPSolution.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STPSolution.Controllers
{
    public class CompaniesEVENTController : Controller
    {
        // GET: CompaniesEVENT
        public ActionResult Index()
        {
            STPEntities3 DB = new STPEntities3();
            List<CompaniesDB> db = DB.CompaniesDBs.ToList();
            return View(db);
        }
    }
}