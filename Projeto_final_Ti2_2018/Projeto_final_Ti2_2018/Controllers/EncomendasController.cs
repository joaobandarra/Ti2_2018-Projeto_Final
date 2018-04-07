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
    public class EncomendasController : Controller
    {
        private DBSuperGes db = new DBSuperGes();

        // GET: Encomendas
        public ActionResult Index()
        {
            var encomendas = db.Encomendas.Include(e => e.Cliente).Include(e => e.RegiaoEnvio).Include(e => e.TipoEnvio);
            return View(encomendas.ToList());
        }

        // GET: Encomendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomenda encomenda = db.Encomendas.Find(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            return View(encomenda);
        }

        // GET: Encomendas/Create
        public ActionResult Create()
        {
            ViewBag.ClienteFK = new SelectList(db.Clientes, "IDCliente", "Nome");
            ViewBag.RegiaoEnvioFK = new SelectList(db.RegiaoEnvio, "IDRegiaoEnvio", "NomeRegiao");
            ViewBag.TipoEnvioFK = new SelectList(db.TiposEnvio, "ID", "TiposEnvio");
            return View();
        }

        // POST: Encomendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDEncomenda,DataCriacaoEncomenda,DataEnvioEncomenda,EstadoCompra,CustoEnvio,MoradaFaturacao,CodPostalFaturacao,MoradaEntrega,CodigoPostalEntrega,ClienteFK,TipoEnvioFK,RegiaoEnvioFK")] Encomenda encomenda)
        {
            if (ModelState.IsValid)
            {
                db.Encomendas.Add(encomenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteFK = new SelectList(db.Clientes, "IDCliente", "Nome", encomenda.ClienteFK);
            ViewBag.RegiaoEnvioFK = new SelectList(db.RegiaoEnvio, "IDRegiaoEnvio", "NomeRegiao", encomenda.RegiaoEnvioFK);
            ViewBag.TipoEnvioFK = new SelectList(db.TiposEnvio, "ID", "TiposEnvio", encomenda.TipoEnvioFK);
            return View(encomenda);
        }

        // GET: Encomendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomenda encomenda = db.Encomendas.Find(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteFK = new SelectList(db.Clientes, "IDCliente", "Nome", encomenda.ClienteFK);
            ViewBag.RegiaoEnvioFK = new SelectList(db.RegiaoEnvio, "IDRegiaoEnvio", "NomeRegiao", encomenda.RegiaoEnvioFK);
            ViewBag.TipoEnvioFK = new SelectList(db.TiposEnvio, "ID", "TiposEnvio", encomenda.TipoEnvioFK);
            return View(encomenda);
        }

        // POST: Encomendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDEncomenda,DataCriacaoEncomenda,DataEnvioEncomenda,EstadoCompra,CustoEnvio,MoradaFaturacao,CodPostalFaturacao,MoradaEntrega,CodigoPostalEntrega,ClienteFK,TipoEnvioFK,RegiaoEnvioFK")] Encomenda encomenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encomenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteFK = new SelectList(db.Clientes, "IDCliente", "Nome", encomenda.ClienteFK);
            ViewBag.RegiaoEnvioFK = new SelectList(db.RegiaoEnvio, "IDRegiaoEnvio", "NomeRegiao", encomenda.RegiaoEnvioFK);
            ViewBag.TipoEnvioFK = new SelectList(db.TiposEnvio, "ID", "TiposEnvio", encomenda.TipoEnvioFK);
            return View(encomenda);
        }

        // GET: Encomendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomenda encomenda = db.Encomendas.Find(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            return View(encomenda);
        }

        // POST: Encomendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encomenda encomenda = db.Encomendas.Find(id);
            db.Encomendas.Remove(encomenda);
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
