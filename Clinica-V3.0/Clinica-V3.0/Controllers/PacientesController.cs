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
    
    public class PacientesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // GET: Pacientes
        public ActionResult Index(string stringNome, string stringTelefone)
        {
            var pacientes = db.Paciente.ToList();
            if (!String.IsNullOrEmpty(stringNome))
            {
                pacientes = pacientes.Where(s => s.Nome.Contains(stringNome)).Select(x => x).ToList();
            }

            if (!String.IsNullOrEmpty(stringTelefone))
            {
                pacientes = pacientes.Where(s => s.Telefone.Contains(stringTelefone)).Select(x => x).ToList(); 
            }

            return View(pacientes);
        }
        [CustomAuthorize(Roles = "Medico,Administrador,Secretaria")]
        // GET: Pacientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // POST: Pacientes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPaciente,Nome,Telefone")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Paciente.Add(paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paciente);
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // GET: Pacientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // POST: Pacientes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPaciente,Nome,Telefone,Endereco,DataNascimento")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // GET: Pacientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }
        [CustomAuthorize(Roles = "Administrador,Secretaria")]
        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paciente paciente = db.Paciente.Find(id);
            db.Paciente.Remove(paciente);
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
            var list = db.Paciente.Where(x => x.Nome.ToLower().Contains(term)).Select(x => x.Nome).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TelefoneFilter(string term)
        {
            term = term.ToLower();
            var list = db.Paciente.Where(x => x.Telefone.ToLower().Contains(term)).Select(x => x.Telefone).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
