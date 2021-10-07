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
            var listAsignatura = new List<Asignatura>()
            {
                new Asignatura{ 
                    name = "Math",
                    description = "This is the first asignature create for statig this project"
                },
                new Asignatura{ 
                    name = "Chemistry",
                    description = "This is the first asignature create for statig this project"
                },
                new Asignatura{ 
                    name = "Literature",
                    description = "This is the first asignature create for statig this project"
                },
                new Asignatura
                {
                    name = "Language",
                    description = "This is the first asignature create for statig this project"
                }
            };
            
            return View(listAsignatura);
        }
    }
}
