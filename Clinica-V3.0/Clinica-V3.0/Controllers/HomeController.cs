using Clinica_V3._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica_V3._0.Controllers
{
    [CustomAuthorize(Roles = "Medico,Administrador,Secretaria")]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.numConsultasHoje = numConsultaHoje();
            ViewBag.totalConsultas = db.Consultas.Count();
            ViewBag.totalPacientes = db.Paciente.Count();
            return View();
        }

        private int numConsultaHoje()
        {
            DateTime diaHoje = DateTime.Now.Date;
            int total = 0;
            foreach (Consulta cons in db.Consultas)
            {
                if (cons.DataConsulta.Date.Equals(diaHoje) && !cons.Comparecimento)
                {
                    total++;
                }
            }
                return total;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}