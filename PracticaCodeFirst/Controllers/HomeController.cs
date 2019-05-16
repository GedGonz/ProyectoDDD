
using PracticaCodeFirst.Models;
using ReglasNegocio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntidadesDTO;
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

           var Persona=IPersonaServicio.ListTopPersonas().FirstOrDefault();

            //var Personadto = new Personadto() { Nombre="Pablo",Apellido="Escobar"};

            //var retorno=IPersonaServicio.Add(Personadto);



            Persona.Nombre = "Pedro";

            var retorno = IPersonaServicio.Update(Persona);

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