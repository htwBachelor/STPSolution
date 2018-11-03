using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using STPSolution.Models;

namespace STPSolution.Controllers
{
    public class CompaniesController : Controller
    {
        // GET: Companies
        public ActionResult ListCompanies()
        {
            var company = new CompaniesDB() { CompanyName = "Simens" };
            return View();
        }
        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }
        
    }
}