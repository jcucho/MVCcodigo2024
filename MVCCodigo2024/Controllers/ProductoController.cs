﻿using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Listar()
        {
            List<Producto> model = new List<Producto>
            {
                new Producto{ Id=1, Nombre="laptop",Precio=1200.50m, Cantidad=5 }
                ,new Producto{ Id=2, Nombre="Smartphone",Precio=800.00m, Cantidad=10 }
                ,new Producto{ Id=3, Nombre="Tablet",Precio=400.50m, Cantidad=7 }
            };

            return View(model);
        }

        public ActionResult BuscarPorId() {
            Producto model = new Producto();
            return View(model);
        }

    }
}