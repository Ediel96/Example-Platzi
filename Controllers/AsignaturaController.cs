using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programacion"
            };

            return View(asignatura);
        }

    }
}
