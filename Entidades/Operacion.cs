using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion : iComision
    {
        public int Id { get; set; }
        public double Capital { get; set; }
        public int Meses { get; set; }

        public virtual double CalcularComision()
        {
            return 0;
        }

        public double GananciaTotal()
        {
            return ( Capital * Meses) + CalcularComision();
        }
    }
}
