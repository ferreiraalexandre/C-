using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ServiceProvidedController : Controller
    {
        private DBContext db = new DBContext();

        // GET: ServiceProvided
        public ActionResult Index()
        {
            var serviceProvided = db.ServiceProvided.Include(s => s.Client);
            return View(serviceProvided.ToList());
        }

        // GET: ServiceProvided/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvided serviceProvided = db.ServiceProvided.Find(id);
            if (serviceProvided == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvided);
        }

        // GET: ServiceProvided/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "Name");
            return View();
        }

        // POST: ServiceProvided/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,Date,Value,Type,ClientId")] ServiceProvided serviceProvided)
        {
            if (ModelState.IsValid)
            {
                db.ServiceProvided.Add(serviceProvided);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "Name", serviceProvided.ClientId);
            return View(serviceProvided);
        }

        // GET: ServiceProvided/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvided serviceProvided = db.ServiceProvided.Find(id);
            if (serviceProvided == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "Name", serviceProvided.ClientId);
            return View(serviceProvided);
        }

        // POST: ServiceProvided/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,Date,Value,Type,ClientId")] ServiceProvided serviceProvided)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceProvided).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientId = new SelectList(db.Client, "ClientId", "Name", serviceProvided.ClientId);
            return View(serviceProvided);
        }

        // GET: ServiceProvided/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvided serviceProvided = db.ServiceProvided.Find(id);
            if (serviceProvided == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvided);
        }

        // POST: ServiceProvided/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ServiceProvided serviceProvided = db.ServiceProvided.Find(id);
            db.ServiceProvided.Remove(serviceProvided);
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
