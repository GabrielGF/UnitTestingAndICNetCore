using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace TPInvestigacion
{
    public class CalculadoraComisionesController : Controller
    {
        private IOperacionService _operacionServicios;

        public CalculadoraComisionesController()
        {
            this._operacionServicios = new OperacionServicios();
        }

        public CalculadoraComisionesController(IOperacionService operacionServicios)
        {
            this._operacionServicios = operacionServicios;
        }

        [HttpGet]
        public ActionResult CalcularComision()
        {
            return View();
        }

        [HttpPost]
        public ActionResult calcularcomision(Operacion o)
        {
            var errores = _operacionServicios.ValidarOperacion(o);

            if (errores.Count > 0)
            {
                ViewBag.Errores = errores;

                return View();
            }


            _operacionServicios.AgregarOperacion(o);

            return Redirect("/CalculadoraComisiones/VerOperaciones");
        }

        [HttpGet]
        public ActionResult VerOperaciones()
        {
            return View(_operacionServicios.ListarOperaciones());
        }
    }
}