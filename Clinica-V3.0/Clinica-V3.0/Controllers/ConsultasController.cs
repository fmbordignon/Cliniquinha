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
    public class ConsultasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Consultas
        public ActionResult Index(string stringPaciente,string stringMedico, string stringPlanoSaude)
        {
            var consultas = db.Consultas.Include(c => c.Paciente);
            if (!String.IsNullOrEmpty(stringPaciente))
            {
                consultas = consultas.Where(s => s.Paciente.Nome.Contains(stringPaciente));
            }

            if (!String.IsNullOrEmpty(stringMedico))
            {
                consultas = consultas.Where(s => s.Medico.Nome.Contains(stringMedico));
            }

            if (!String.IsNullOrEmpty(stringPlanoSaude))
            {
                consultas = consultas.Where(s => s.PlanoDeSaude.Contains(stringPlanoSaude));
            }

            return View(consultas.ToList());
        }

        // GET: Consultas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // GET: Consultas/Create
        public ActionResult Create()
        {
            ViewBag.IDPaciente = new SelectList(db.Paciente, "IDPaciente", "Nome");
            ViewBag.IDMedico = new SelectList(db.Medico, "UserId", "Nome");
            return View();
        }

        // POST: Consultas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDConsulta,PlanoDeSaude,DataConsulta,IDPaciente,IDMedico")] Consulta consulta, string hora)
        {
            if (ModelState.IsValid)
            {
                string[] array = hora.Split(':');

                DateTime novaData = new DateTime(consulta.DataConsulta.Year, consulta.DataConsulta.Month, consulta.DataConsulta.Day, int.Parse(array[0]), int.Parse(array[1]), 00);
                consulta.DataConsulta = novaData;
                db.Consultas.Add(consulta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDPaciente = new SelectList(db.Paciente, "IDPaciente", "Nome", consulta.IDPaciente);
            ViewBag.IDMedico = new SelectList(db.Medico, "UserId", "Nome", consulta.IDMedico);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDPaciente = new SelectList(db.Paciente, "IDPaciente", "Nome", consulta.IDPaciente);
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDConsulta,PlanoDeSaude,DataConsulta,IDPaciente,IDMedico")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consulta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDPaciente = new SelectList(db.Paciente, "IDPaciente", "Nome", consulta.IDPaciente);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consulta consulta = db.Consultas.Find(id);
            db.Consultas.Remove(consulta);
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

        public ActionResult PacienteFilter(string term)
        {
            term = term.ToLower();
            var list = db.Consultas.Where(x => x.Paciente.Nome.ToLower().Contains(term)).Select(x => x.Paciente.Nome).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MedicoFilter(string term)
        {
            term = term.ToLower();
            var list = db.Consultas.Where(x => x.Medico.Nome.ToLower().Contains(term)).Select(x => x.Medico.Nome).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PlanoSaudeFilter(string term)
        {
            term = term.ToLower();
            var list = db.Consultas.Where(x => x.PlanoDeSaude.ToLower().Contains(term)).Select(x => x.PlanoDeSaude).Distinct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
