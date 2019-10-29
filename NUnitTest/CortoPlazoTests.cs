using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class CortoPlazoTests
    {
        [TestCase]
        public void TestQueCompruebaQueSeCalculaCorrectamenteUnaComision()
        {
            //Arrage o Preparación
            CortoPlazo cp = new CortoPlazo();
            cp.Capital = 1000;
            cp.Meses = 4;
            double expected = 200;

            //Act ó Ejecución
            double actual = cp.CalcularComision();

            //Assert ó Contrastación
            Assert.Equals(expected, actual);
        }
    }
}
