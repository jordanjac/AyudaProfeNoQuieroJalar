using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PaqueteTuristico.Entities;
using PaqueteTuristico.Persistence;
using PaqueteTuristico.Persistence.Repositories;

namespace PaqueteTuristico.MVC.Controllers
{
    public class AlimentacionsController : Controller
    {
        //private PaqueteTuristicoDbContext db = new PaqueteTuristicoDbContext();
        private UnityOfWork unityOfWork = UnityOfWork.Instance;

        // GET: Alimentacions
        public ActionResult Index()
        {
            //var alimentaciones = db.Alimentaciones.Include(a => a.Paquete);
            return View(unityOfWork.Alimentaciones.GetAll());
        }

        // GET: Alimentacions/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Alimentacion alimentacion = db.Alimentaciones.Find(id);
            Alimentacion alimentacion = unityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // GET: Alimentacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlimentacionId,Name,PaqueteId")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.Alimentaciones.Add(alimentacion);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.PaqueteId = new SelectList(db.Paquetes, "PaqueteId", "Name", alimentacion.PaqueteId);
            return View(alimentacion);
        }

        // GET: Alimentacions/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = unityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PaqueteId = new SelectList(db.Paquetes, "PaqueteId", "Name", alimentacion.PaqueteId);
            return View(alimentacion);
        }

        // POST: Alimentacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlimentacionId,Name,PaqueteId")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(alimentacion).State = EntityState.Modified;
                unityOfWork.StateModified(alimentacion);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.PaqueteId = new SelectList(db.Paquetes, "PaqueteId", "Name", alimentacion.PaqueteId);
            return View(alimentacion);
        }

        // GET: Alimentacions/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Alimentacion alimentacion = db.Alimentaciones.Find(id);
            Alimentacion alimentacion = unityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Alimentacion alimentacion = db.Alimentaciones.Find(id);
            Alimentacion alimentacion = unityOfWork.Alimentaciones.Get(id);

            //db.Alimentaciones.Remove(alimentacion);
            unityOfWork.Alimentaciones.Delete(alimentacion);

            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
