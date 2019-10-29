using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMSTest.Test
{
    [TestClass]
    public class CortoPlazoTest
    {
        [TestMethod]
        public void CalcularComisionTest()
        {

            //Arrage o Preparación
            CortoPlazo cp = new CortoPlazo();
            cp.Capital = 1000;
            cp.Meses = 4;
            double expected = 200;

            //Act ó Ejecución
            double actual = cp.CalcularComision();

            //Assert ó Contrastación
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
