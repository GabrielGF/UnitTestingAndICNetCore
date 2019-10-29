using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPInvestigacion.Controllers
{
    public class PresentacionController : Controller
    {
        // GET: Presentacion
        public ActionResult Bienvenido()
        {
            return View();
        }
    }
}