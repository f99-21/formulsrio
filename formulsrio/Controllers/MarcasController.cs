using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using formulsrio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace formulsrio.Controllers
{
    public class MarcasController : Controller
    {
        /**
        private readonly equiposDbContext _context;

        public MarcasController(equiposDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _context.marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            var listadoDeEquipos = (from e in _context.equipos
                                    join m in _context.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marcas_id = m.id_marcas,
                                        marca_nombre = m.nombre_marca,
                                    }).ToList();

            ViewData["listadoEquipo"] = listadoDeEquipos;
            return View();
        }

        public IActionResult CrearEquipo(equipos nuevoEquipo)
        {
            _context.Add(nuevoEquipo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }**/
        
    }
}
