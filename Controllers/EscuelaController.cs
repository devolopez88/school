using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var objEscuela = new Escuela();
            objEscuela.anio = 2022;
            objEscuela.Id = Guid.NewGuid().ToString();
            objEscuela.Nombre = "Jose Celestino Mutis Class";
            //  ViewBag
            ViewBag.info1 = "Info base";
            return View(objEscuela);
        }
    }
}
