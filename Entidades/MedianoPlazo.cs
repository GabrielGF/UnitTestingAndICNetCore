using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedianoPlazo : Operacion
    {
        public override double CalcularComision()
        {
            double a = Meses * Capital;
            return a * 0.07 + 1000;
        }

        public MedianoPlazo(Operacion o)
        {
            this.Meses = o.Meses;
            this.Capital = o.Capital;
            this.Id = o.Id;
        }

        public MedianoPlazo() { }
    }
}
