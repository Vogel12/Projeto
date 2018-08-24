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
    public class equipamentosController : Controller
    {
        private equipamentosContexto db = new equipamentosContexto();

        // GET: equipamentos
        public ActionResult Index()
        {
            return View(db.equipamentos.ToList());
        }

        // GET: equipamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // GET: equipamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: equipamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Handle,Equipamento,Descricao,Quantidade,Uso,Data")] equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                db.equipamentos.Add(equipamentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipamentos);
        }

        // GET: equipamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // POST: equipamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Handle,Equipamento,Descricao,Quantidade,Uso,Data")] equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipamentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipamentos);
        }

        // GET: equipamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // POST: equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            equipamentos equipamentos = db.equipamentos.Find(id);
            db.equipamentos.Remove(equipamentos);
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
