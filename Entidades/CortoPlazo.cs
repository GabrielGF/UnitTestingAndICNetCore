using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CortoPlazo : Operacion
    {
  
    public override double CalcularComision() 
    {
            if (Meses <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        double a = Meses * Capital;
        return a * 0.05;              
    }

        public CortoPlazo(Operacion o)
        {
            this.Meses = o.Meses;
            this.Capital = o.Capital;
            this.Id = o.Id;
        }

        public CortoPlazo() { }
    }
}
