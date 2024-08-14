using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            Session["mensaje"] = "Soy Juan Cucho";
            ViewBag.Mensaje = "Bienvenido a Codigo";
            ViewBag.FechaHora = DateTime.Now.ToLongTimeString();
            return View();
        }

        // GET: Demo
        public string HolaMundo()
        {
            return "<h1>Hola mundo</h1>";
        }

        // GET: Demo
        public string HolaCodigo()
        {
            return "<h1>Hola Codigo</h1>";
        }
        public string formulario()
        {
            string htmlForm = @"<!DOCTYPE html>
<html>
<head>
    <title>Formulario Web Simple</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .form-container {
            max-width: 400px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group button {
            padding: 10px 15px;
            border: none;
            background-color: #007BFF;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }
        .form-group button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class='form-container'>
        <h2>Formulario Web Simple</h2>
        <form action='#' method='post'>
            <div class='form-group'>
                <label for='name'>Nombre:</label>
                <input type='text' id='name' name='name' required />
            </div>
            <div class='form-group'>
                <label for='email'>Correo Electrónico:</label>
                <input type='email' id='email' name='email' required />
            </div>
            <div class='form-group'>
                <button type='submit'>Enviar</button>
            </div>
        </form>
    </div>
</body>
</html>";
            return htmlForm;
        }

        // GET: Demo
        public ActionResult Index2()
        {
            return View();
        }

        // GET: Demo
        public ActionResult ListarPersonas()
        {
            return View();
        }
        public ActionResult Example()
        {
            return View();    
        }
        public ActionResult Exercise()
        {
            return View();
        }
        public ActionResult Table()
        {
            return View();
        }
        public ActionResult Nombres()
        {
            return View();
        }
    }
}