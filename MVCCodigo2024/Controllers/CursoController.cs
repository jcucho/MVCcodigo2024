using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Listar()
        {
            List<Curso> model = new List<Curso>
            {
                new Curso{ Id=1, Nombre="Vb.net",Creditos=5 }
                ,new Curso{ Id=2, Nombre="C#",Creditos=10 }
                ,new Curso{ Id=3, Nombre="Java",Creditos=7 }
            };
            return View(model);
        }
    }
}