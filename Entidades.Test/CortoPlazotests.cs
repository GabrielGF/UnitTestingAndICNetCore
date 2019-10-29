using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Entidades.Test
{
    public class CortoPlazotests
    {
        public void CalcularComision_CalculaCorrectamentaUnaComosion()
        {
            CortoPlazo cp = new CortoPlazo();
            cp.Capital = 1000;
            cp.Meses = 4;
            double valorEsperado = 200;

            double actual = cp.CalcularComision();
        }
    }
}
