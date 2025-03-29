using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using CasaCambio.Models;

namespace CasaCambio.Controllers
{
    public class CambioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcularCambio(CambioModel model)
        {
            model.Resultado = model.Cantidad * ObtenerTipoCambio(model.MonedaOrigen, model.MonedaDestino);
            return View("Resultado", model);
        }

        private decimal ObtenerTipoCambio(string origen, string destino)
        {
            if (origen == "BRL" && destino == "PEN") return 0.75m; // Simulación de TC
            if (origen == "PEN" && destino == "BRL") return 1.33m;
            return 1.0m;
        }

        [HttpGet]
        public IActionResult Boleta(string nombre, string email, string documento, decimal cantidad, string monedaOrigen, decimal resultado, string monedaDestino)
        {
            var boleta = new BoletaModel
            {
                Nombre = nombre,
                Email = email,
                Documento = documento,
                Cantidad = cantidad,
                MonedaOrigen = monedaOrigen,
                Resultado = resultado,
                MonedaDestino = monedaDestino
            };
            return View(boleta);
        }
    }
}