using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IOperacionService
    {
        List<string> ValidarOperacion(Operacion o);
        void AgregarOperacion(Operacion o);
        List<Operacion> ListarOperaciones();

    }
}
