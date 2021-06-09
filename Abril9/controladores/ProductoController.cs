using Abril9.repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abril9.controladores
{
    public class ProductoController : Controller
    {
        // http://localhost:????/Producto/Index
        // http://localhost:????/Producto/
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:????/Producto/Listar
        public IActionResult Listar()
        {
            // 4) y enviar a la vista los datos a mostrar
            ViewBag.productos=ProductoRepo.ListarTodo();
            ViewData["productos"]=ProductoRepo.ListarTodo();

            // Modelo.
            // MVC Modelo Vista Controlador

            return View();
        }

    }
}
