using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameJamProyecto.Models;

namespace GameJamProyecto.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(Jugador jugador)
    {
        // Aquí aplicamos la lógica que te pidieron
        if (jugador.PagoRealizado)
        {
            ViewBag.Mensaje = "Completado su registro.";
            ViewBag.ClaseCss = "alert-success"; // Color verde
        }
        else
        {
            ViewBag.Mensaje = "Ud. aún no ha completado su pago.";
            ViewBag.ClaseCss = "alert-danger"; // Color rojo
        }

        return View("Index");
    }
}
