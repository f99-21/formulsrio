using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using formulsrio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace formulsrio.Controllers
{
    public class MarcasController : Controller
    {
       

        public IActionResult Index()
        {
         
            return View();
        }

      
        
    }
}
