using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public class OperacionServicios
    {
        private static List<Operacion> ListaOperaciones = new List<Operacion>();

        public static void AgregarOperacion(Operacion o)
        {
            o.Id = ListaOperaciones.Count() + 1;

            if (o.Meses > 0 && o.Meses <= 4)
            {
                o = new CortoPlazo(o);
                ListaOperaciones.Add(o);
            }
            else if (o.Meses > 4 && o.Meses <= 18)
            {
                o = new MedianoPlazo(o);
                ListaOperaciones.Add(o);
            }
            else if (o.Meses > 18 && o.Meses <= 36)
            {
                o = new LargoPlazo(o);
                ListaOperaciones.Add(o);
            }
        }

        public static List<Operacion> ListarOperaciones()
        {
            if (ListaOperaciones.Count() == 0)
            {
                MedianoPlazo mp = new MedianoPlazo();
                mp.Id = ListaOperaciones.Count() + 1;
                mp.Meses = 10;
                mp.Capital = 1000;
                ListaOperaciones.Add(mp);

                CortoPlazo cp = new CortoPlazo();
                cp.Id = ListaOperaciones.Count() + 1;
                cp.Meses = 4;
                cp.Capital = 30000;
                ListaOperaciones.Add(cp);
            }

            return ListaOperaciones;
        }
    }
}
