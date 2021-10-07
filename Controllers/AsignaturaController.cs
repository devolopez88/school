using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project.Models;

namespace project.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var objAsignatura = new Asignatura();
            objAsignatura.name = "Matematicas";
            objAsignatura.description = "This is the first asignature create for statig this project";
            return View(objAsignatura);
        }
    }
}
