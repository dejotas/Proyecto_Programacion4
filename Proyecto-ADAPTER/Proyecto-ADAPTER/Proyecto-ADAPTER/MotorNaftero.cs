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
            Console.WriteLine("Acelerando el motor naftero..");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor naftero..");
        }

        public override void CargarConbustible()
        {
            Console.WriteLine("Cargando conustible a el motor naftero..");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor naftero..");
        }
    }
}
