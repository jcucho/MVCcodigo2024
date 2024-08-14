using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ProductosClientesController : Controller
    {
        // GET: ProductosClientes
        public ActionResult Listar()
        {
            ProductoCliente model=new ProductoCliente();

            List<Producto> productos = new List<Producto>
            {
                new Producto{ Id=1, Nombre="laptop",Precio=1200.50m, Cantidad=5 }
                ,new Producto{ Id=2, Nombre="Smartphone",Precio=800.00m, Cantidad=10 }
                ,new Producto{ Id=3, Nombre="Tablet",Precio=400.50m, Cantidad=7 }
            };

            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente{ ClienteID=1, Nombre="Juan" }
                ,new Cliente{ ClienteID=2, Nombre="Carlos"}
                ,new Cliente{ ClienteID=3, Nombre="Alex"}
            };
            model.Clientes = clientes;
            model.Productos = productos;

            return View(model);
        }
    }
}