using Microsoft.AspNetCore.Mvc;
using GameJamApp.Models;

namespace GameJamApp.Controllers
{
    public class GameJamController : Controller
    {
        // GET: Muestra el formulario
        public IActionResult Registro()
        {
            return View();
        }

        // POST: Recibe los datos y decide qué mensaje mostrar
        [HttpPost]
        public IActionResult Registro(Jugador jugador)
        {
            if (jugador.PagoMatricula)
            {
                ViewBag.Mensaje = "Usted ha completado su registro exitosamente.";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Mensaje = "Usted aún no ha completado su pago.";
                ViewBag.Status = "danger";
            }
            return View(jugador);
        }
    }
}