using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MenuMVC.Models.Concrete;
using MenuMVC.Models.ViewModels;

namespace MenuMVC.Controllers
{
    public class HomeController : Controller
    {
        private IndexRepository repository;

        public HomeController()
        {
            this.repository = new IndexRepository();
        }

        public ActionResult Index()
        {
            return View(repository.index);
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