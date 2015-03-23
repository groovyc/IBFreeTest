using IBFree.Models;  ///added
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IBFree.Controllers
{
    public class HomeController : Controller
    {

        private IBFreeContext db = new IBFreeContext();
        //retrieve data from database. 

        public ActionResult Index()
        {
            var BadFood = db.BoldFoods.ToList();
            
                return View(BadFood);
            

         
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