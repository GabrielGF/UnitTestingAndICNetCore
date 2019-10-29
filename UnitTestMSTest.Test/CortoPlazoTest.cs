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
    public class CortoPlazoTest
    {
        [TestMethod]
        public void CalcularComisionTest()
        {

            //Arrage o Preparaci�n
            CortoPlazo cp = new CortoPlazo();
            cp.Capital = 1000;
            cp.Meses = 4;
            double expected = 200;

            //Act � Ejecuci�n
            double actual = cp.CalcularComision();

            //Assert � Contrastaci�n
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcularComisionThrowExceptionTest()
        {
            CortoPlazo cp = new CortoPlazo();
            cp.Meses = 0;
            cp.Capital = 1000;
            cp.CalcularComision();
        }
    }
}
