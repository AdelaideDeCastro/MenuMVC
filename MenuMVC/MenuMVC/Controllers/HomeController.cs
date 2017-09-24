using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MenuMVC.Models.Concrete;

namespace MenuMVC.Controllers
{
    public class HomeController : Controller
    {
        private EFWeekDisheRepository repository;

        public HomeController()
        {
            this.repository = new EFWeekDisheRepository();
        }

        public ActionResult Index()
        {
            return View(repository.WeekDishes);
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