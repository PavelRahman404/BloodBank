using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodBankExam.Models;

namespace BloodBankExam.Controllers
{
    
    public class HomeController : Controller
    {
        BloodBankExamEntities db = new BloodBankExamEntities();
        public ActionResult Index()
        {
            var req= db.Requests.OrderByDescending(r => r.ReqID).Take(6);
            ViewBag.Request=req;    
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