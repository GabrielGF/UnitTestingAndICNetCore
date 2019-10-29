using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Servicios;
using TPInvestigacion;

namespace UnitTestMSTest.Test
{
    [TestClass]
    public class CalculadoraComisionesControllerTest
    {
        [TestMethod]
        public void Calcularcomision_ForzarErrores()
        {
            Operacion o = new Operacion();
            var mockOperacionesServicio = new Mock<IOperacionService>();
            mockOperacionesServicio.Setup(_ => _.ValidarOperacion(o)).Returns(new List<string> { "error1", "error2" });

            CalculadoraComisionesController controller = new CalculadoraComisionesController(mockOperacionesServicio.Object);

            var resultado = controller.calcularcomision(o);

            // ViewBag tiene que tener los errores.
            Assert.IsNotNull(controller.ViewBag.Errores);

            // Verifica que el tipo sea ViewResult
            Assert.IsInstanceOfType(resultado, typeof(ViewResult));

            // AgregarOperacion no tiene que ser llamado.
            mockOperacionesServicio.Verify(_ => _.AgregarOperacion(o), Times.Never());

            // ValidarOperacion debe ser llamado
            mockOperacionesServicio.Verify(_ => _.ValidarOperacion(o), Times.AtLeastOnce());
        }

        [TestMethod]
        public void Calcularcomision_SinErrores()
        {
            Operacion o = new Operacion();
            var mockOperacionesServicio = new Mock<IOperacionService>();
            mockOperacionesServicio.Setup(_ => _.ValidarOperacion(o)).Returns(new List<string>() { });

            CalculadoraComisionesController controller = new CalculadoraComisionesController(mockOperacionesServicio.Object);

            var resultado = controller.calcularcomision(o);

            // ViewBag NO tiene que tener los errores.
            Assert.IsNull(controller.ViewBag.Errores);

            // Verifica que el tipo sea RedirectResult
            Assert.IsInstanceOfType(resultado, typeof(RedirectResult));

            // AgregarOperacion tiene que ser llamado.
            mockOperacionesServicio.Verify(_ => _.AgregarOperacion(o), Times.Once());

            // ValidarOperacion debe ser llamado
            mockOperacionesServicio.Verify(_ => _.ValidarOperacion(o), Times.AtLeastOnce());
        }

    }
}
