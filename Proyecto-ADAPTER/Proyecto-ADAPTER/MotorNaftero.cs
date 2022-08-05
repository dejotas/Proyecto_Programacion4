using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADAPTER
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.Write("Acelerando el motor naftero..");
        }

        public override void Arrancar()
        {
            Console.Write("Arrancando el motor naftero..");
        }

        public override void CargarConbustible()
        {
            Console.Write("Cargando conustible a el motor naftero..");
        }

        public override void Detener()
        {
            Console.Write("Deteniendo el motor naftero..");
        }
    }
}
