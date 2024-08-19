using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();
            if(Session["Personas"] == null)
            {
                personas.Add(new Persona { Id = 1, Apellidos = "Cucho", Nombres = "Juan" });
                personas.Add(new Persona { Id = 2, Apellidos = "Marla", Nombres = "Chapilliquen" });
                Session["Personas"] = personas;
            } 
            else
            {
                personas = (List<Persona>)Session["Personas"];
            }
            
            return View(personas);
        }

        // GET: Personas/Details/5
        public ActionResult Details(int id)
        {
            var persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var personas = ((List<Persona>)Session["Personas"]);
                    int maxId = personas.Max(p => p.Id);
                    persona.Id = maxId + 1;
                    ((List<Persona>)Session["Personas"]).Add(persona);
                    // TODO: Add insert logic here
                    return RedirectToAction("Index");
                }
                return View(persona);
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int id)
        {
            var persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
            return View(persona);
        }

        // POST: Personas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Persona persona)
        {
            try
            {
                // TODO: Add update logic here
                var personaEncontrada = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                ((List<Persona>)Session["Personas"]).Remove(personaEncontrada);
                ((List<Persona>)Session["Personas"]).Add(personaEncontrada);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int id)
        {
            var persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Persona persona)
        {
            try
            {
                var personaEliminar = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
                ((List<Persona>)Session["Personas"]).Remove(personaEliminar);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
