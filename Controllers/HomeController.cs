using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradersPortal.Models;
using System.Data.Entity;


namespace TradersPortal.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //public ActionResult Index()
        //{

          

        //    return View();
        //}

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


        public ActionResult AdminPage()
        {
            return View();
        }




        // GET: Traders
        [Authorize(Roles = "CanManageTraders")]
        public ActionResult Index(string option, string search, string prefix)
        {

            var traders = db.Traders
                .Include(t => t.Trade)
                .Include(s =>s.State)
                .ToList();

            if (option == "StateName" && string.IsNullOrWhiteSpace(search))
            {
                return View(traders);
                
            }


            else if (option == "StateName")
            {

                return View(db.Traders.Include(t => t.Trade).Include(s => s.State).Where(t => t.State.StateName == search).ToList());

            }


            else if (option == "TradeName" && string.IsNullOrWhiteSpace(search))
            {
                return View(traders);

            }

            else if (option == "TradeName")
            {

                return View(db.Traders.Include(t => t.Trade).Include(s => s.State).Where(t => t.Trade.TradeName == search).ToList());

            }







            else
            {
                return View(db.Traders.Include(t => t.State).Include(t => t.Trade).ToList());
            }

             
           


        }


       
    }





}