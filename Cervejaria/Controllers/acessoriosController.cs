using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cervejaria.Models;

namespace Cervejaria.Controllers
{
    public class acessoriosController : Controller
    {
        private acessoriosContexto db = new acessoriosContexto();

        // GET: acessorios
        public ActionResult Index()
        {
            return View(db.acessorios.ToList());
        }

        // GET: acessorios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // GET: acessorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: acessorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Handle,Acessorio,Descricao,Uso,Quantidade,Data")] acessorios acessorios)
        {
            if (ModelState.IsValid)
            {
                db.acessorios.Add(acessorios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acessorios);
        }

        // GET: acessorios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // POST: acessorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Handle,Acessorio,Descricao,Uso,Quantidade,Data")] acessorios acessorios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acessorios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acessorios);
        }

        // GET: acessorios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // POST: acessorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            acessorios acessorios = db.acessorios.Find(id);
            db.acessorios.Remove(acessorios);
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
