using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> model = new List<Cliente>();
            model.Add(new Cliente { ClienteID = 1, Apellido = "Cucho", Nombre = "Juan", Edad = 39 });
            model.Add(new Cliente { ClienteID = 1, Apellido = "Cucho", Nombre = "Juan", Edad = 39 });
            model.Add(new Cliente { ClienteID = 1, Apellido = "Cucho", Nombre = "Juan", Edad = 39 });
            model.Add(new Cliente { ClienteID = 1, Apellido = "Cucho", Nombre = "Juan", Edad = 39 });

            return View(model);
        }
        public ActionResult Create()
        {
           Cliente model = new Cliente();
            return View();
        }
    }
}