using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clinica_V3._0.Models;

namespace Clinica_V3._0.Controllers
{
    public class AdministradoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Administradores
        public ActionResult Index(string stringNome)
        {
            var administradors = db.Administradores.ToList();
            if (!String.IsNullOrEmpty(stringNome))
            {
                administradors = administradors.Where(s => s.Nome.Contains(stringNome)).ToList();
            }
            return View(administradors);
        }

        // GET: Administradores/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // GET: Administradores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administradores/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Nome,Rg,Telefone,Endereco")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                db.Administradores.Add(administrador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrador);
        }

        // GET: Administradores/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            //ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", administrador.UserId);
            return View(administrador);
        }

        // POST: Administradores/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Nome,Rg,Telefone,Endereco")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", administrador.UserId);
            return View(administrador);
        }

        // GET: Administradores/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // POST: Administradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Administrador administrador = db.Administradores.Find(id);
            db.Administradores.Remove(administrador);
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

        public ActionResult NomeFilter(string term)
        {
            term = term.ToLower();
            var list = db.Administradores.Where(x => x.Nome.ToLower().Contains(term)).Select(x => x.Nome).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
