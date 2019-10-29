using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace TPInvestigacion
{
    public class CalculadoraComisionesController : Controller
    {
        [HttpGet]
        public ActionResult CalcularComision()
        {
            return View();
        }

        [HttpPost]
        public ActionResult calcularcomision(Operacion o)
        {
            OperacionServicios.AgregarOperacion(o);
            return Redirect("/CalculadoraComisiones/VerOperaciones");
        }
        [HttpGet]
        public ActionResult VerOperaciones()
        {
            return View(OperacionServicios.ListarOperaciones());
        }
    }
}