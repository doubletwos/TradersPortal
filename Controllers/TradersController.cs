using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TradersPortal.Models;

namespace TradersPortal.Controllers
{
    public class TradersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Traders
        public ActionResult Index()
        {
            var traders = db.Traders.Include(t => t.State).Include(t => t.Trade);
            return View(traders.ToList());
        }

        // GET: Traders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trader trader = db.Traders.Find(id);
            if (trader == null)
            {
                return HttpNotFound();
            }
            return View(trader);
        }

        // GET: Traders/Create
        public ActionResult Create()
        {
            ViewBag.StateId = new SelectList(db.States, "StateId", "StateName");
            ViewBag.TradeId = new SelectList(db.Trades, "TradeId", "TradeName");
            return View();
        }

        // POST: Traders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TraderId,BusinessName,ContactFirstName,ContactLastName,Telephone,Mobile,Email,RegistrationDate,TradeId,StateId")] Trader trader)
        {
            if (ModelState.IsValid)
            {
                db.Traders.Add(trader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StateId = new SelectList(db.States, "StateId", "StateName", trader.StateId);
            ViewBag.TradeId = new SelectList(db.Trades, "TradeId", "TradeName", trader.TradeId);
            return View(trader);
        }

        // GET: Traders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trader trader = db.Traders.Find(id);
            if (trader == null)
            {
                return HttpNotFound();
            }
            ViewBag.StateId = new SelectList(db.States, "StateId", "StateName", trader.StateId);
            ViewBag.TradeId = new SelectList(db.Trades, "TradeId", "TradeName", trader.TradeId);
            return View(trader);
        }

        // POST: Traders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TraderId,BusinessName,ContactFirstName,ContactLastName,Telephone,Mobile,Email,RegistrationDate,TradeId,StateId")] Trader trader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StateId = new SelectList(db.States, "StateId", "StateName", trader.StateId);
            ViewBag.TradeId = new SelectList(db.Trades, "TradeId", "TradeName", trader.TradeId);
            return View(trader);
        }

        // GET: Traders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trader trader = db.Traders.Find(id);
            if (trader == null)
            {
                return HttpNotFound();
            }
            return View(trader);
        }

        // POST: Traders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trader trader = db.Traders.Find(id);
            db.Traders.Remove(trader);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
