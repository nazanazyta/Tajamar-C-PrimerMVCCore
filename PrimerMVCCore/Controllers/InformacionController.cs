using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerMVCCore.Models;

namespace PrimerMVCCore.Controllers
{
    public class InformacionController : Controller
    {
        //GET VistaPost
        [HttpGet]
        public IActionResult VistaPost()
        {
            return View();
        }

        //POST VistaPost
        [HttpPost]
        public IActionResult VistaPost(String cajanombre, int cajaedad, String cajaemail)
        {
            Persona persona = new Persona();
            persona.Nombre = cajanombre;
            persona.Edad = cajaedad;
            persona.Email = cajaemail;
            //ViewData["Nombre"] = cajanombre;
            //ViewData["Edad"] = cajaedad;
            //ViewData["Email"] = cajaemail;
            return View(persona);
        }

        //GET VistaDatos
        public IActionResult VistaDatos(String aplicacion, int version)
        {
            //LOS PARÁMETROS VAN ENLAZADOS POR SU name
            //Y SON OPCIONALES
            ViewBag.Aplicacion = aplicacion;
            ViewBag.Version = version;
            return View();
        }

        //POST
        //public IActionResult VistaPost()
        //{
        //    return View();
        //}

        //PARA CAPTURAR LA INFORMACIÓN DE UN FORMULARIO
        //NECESITAMOS UN MÉTODO EXTRA POST
        //DICHO MÉTODO DEBE TENER EL ATRIBUTO [HttpPost]
        //RECIBE LOS PARÁMETROS CON EL MISMO name
        //QUE LAS CAJAS O INPUT
        //PARA QUE SEA FUNCIONAL TIENE QUE TENER [HttpPost]
        //[HttpPost]
        //public IActionResult VistaPost(String cajanombre, String cajaedad)
        //{
        //    ViewBag.Nombre = cajanombre;
        //    ViewBag.Edad = cajaedad;
        //    return View();
        //}

        public IActionResult Inicio()
        {
            //ViewBag.Nombre = "Usuario";
            ViewBag.Edad = 27;
            ViewData["nombre"] = "Naza";
            //ViewData["edad"] = 29;
            Persona person = new Persona();
            person.Nombre = "Soy un modelo";
            person.Edad = 99;
            person.Email = "email@email.com";
            //TODOS LOS MÉTODOS DEBEN DEVOLVER UNA VISTA
            return View(person);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
