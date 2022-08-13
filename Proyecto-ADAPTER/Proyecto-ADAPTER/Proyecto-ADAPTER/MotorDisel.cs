using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADAPTER
{
    public class MotorDisel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor Disel..");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor Disel..");
        }

        public override void CargarConbustible()
        {
            Console.WriteLine("Cargando conbustible al motor Disel..");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el  motor Disel..");
        }
    }
}
