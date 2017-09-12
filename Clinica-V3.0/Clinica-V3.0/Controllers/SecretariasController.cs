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
    [CustomAuthorize(Roles = "Administrador,Secretaria")]
    public class SecretariasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Secretarias
        public ActionResult Index(string stringNome)
        {
            var secretarias = db.Secretaria.ToList();
            if (!String.IsNullOrEmpty(stringNome))
            {
                secretarias = secretarias.Where(s => s.Nome.Contains(stringNome)).ToList();
            }

            return View(secretarias);
        }

        // GET: Secretarias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secretaria secretaria = db.Secretaria.Find(id);
            if (secretaria == null)
            {
                return HttpNotFound();
            }
            return View(secretaria);
        }

        // GET: Secretarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secretarias/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Nome,Rg,Telefone,Endereco,Especializacao")] Secretaria secretaria)
        {
            if (ModelState.IsValid)
            {
                db.Secretaria.Add(secretaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secretaria);
        }

        // GET: Secretarias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secretaria secretaria = db.Secretaria.Find(id);
            if (secretaria == null)
            {
                return HttpNotFound();
            }
            return View(secretaria);
        }

        // POST: Secretarias/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Nome,Rg,Telefone,Endereco,Especializacao")] Secretaria secretaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secretaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secretaria);
        }

        // GET: Secretarias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Secretaria secretaria = db.Secretaria.Find(id);
            if (secretaria == null)
            {
                return HttpNotFound();
            }
            return View(secretaria);
        }

        // POST: Secretarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Secretaria secretaria = db.Secretaria.Find(id);
            db.Secretaria.Remove(secretaria);
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
            var list = db.Secretaria.Where(x => x.Nome.ToLower().Contains(term)).Select(x => x.Nome).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
