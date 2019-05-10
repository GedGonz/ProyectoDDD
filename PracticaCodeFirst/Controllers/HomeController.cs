
using PracticaCodeFirst.Models;
using ReglasNegocio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonaServicio IPersonaServicio;
        public HomeController(IPersonaServicio IPersonaServicio)
        {
            this.IPersonaServicio = IPersonaServicio;
        }
        public ActionResult Index()
        {

           var ListaPersonasTop=IPersonaServicio.ListTopPersonas();

           return View();
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