using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BrainBeer.Models;

namespace BrainBeer.Controllers
{
    public class AcessoriosController : Controller
    {
        private Contextos db = new Contextos();

        // GET: Acessorios
        public ActionResult Index()
        {
            return View(db.acessorios.ToList());
        }

        // GET: Acessorios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // GET: Acessorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acessorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Handle,Produto,Descricao,Quantidade,DataCompra")] Acessorios acessorios)
        {
            if (ModelState.IsValid)
            {
                db.acessorios.Add(acessorios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acessorios);
        }

        // GET: Acessorios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // POST: Acessorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Handle,Produto,Descricao,Quantidade,DataCompra")] Acessorios acessorios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acessorios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acessorios);
        }

        // GET: Acessorios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acessorios acessorios = db.acessorios.Find(id);
            if (acessorios == null)
            {
                return HttpNotFound();
            }
            return View(acessorios);
        }

        // POST: Acessorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Acessorios acessorios = db.acessorios.Find(id);
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
