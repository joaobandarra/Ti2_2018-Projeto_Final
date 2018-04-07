using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projeto_final_Ti2_2018.Models;

namespace Projeto_final_Ti2_2018.Controllers
{
    public class SubCategoriasController : Controller
    {
        private DBSuperGes db = new DBSuperGes();

        // GET: SubCategorias
        public ActionResult Index()
        {
            var subCatergorias = db.SubCatergorias.Include(s => s.Categoria);
            return View(subCatergorias.ToList());
        }

        // GET: SubCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCatergorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // GET: SubCategorias/Create
        public ActionResult Create()
        {
            ViewBag.IDCategoriaFK = new SelectList(db.Categorias, "IDCategoria", "Nome");
            return View();
        }

        // POST: SubCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDSubCategoria,Nome,IDCategoriaFK")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.SubCatergorias.Add(subCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCategoriaFK = new SelectList(db.Categorias, "IDCategoria", "Nome", subCategoria.IDCategoriaFK);
            return View(subCategoria);
        }

        // GET: SubCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCatergorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCategoriaFK = new SelectList(db.Categorias, "IDCategoria", "Nome", subCategoria.IDCategoriaFK);
            return View(subCategoria);
        }

        // POST: SubCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSubCategoria,Nome,IDCategoriaFK")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCategoriaFK = new SelectList(db.Categorias, "IDCategoria", "Nome", subCategoria.IDCategoriaFK);
            return View(subCategoria);
        }

        // GET: SubCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCatergorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // POST: SubCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubCategoria subCategoria = db.SubCatergorias.Find(id);
            db.SubCatergorias.Remove(subCategoria);
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
