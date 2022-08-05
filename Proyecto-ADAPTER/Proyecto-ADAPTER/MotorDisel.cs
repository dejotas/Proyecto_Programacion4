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
            Console.Write("Acelerando el motor Disel..");
        }

        public override void Arrancar()
        {
            Console.Write("Arrancando el motor Disel..");
        }

        public override void CargarConbustible()
        {
            Console.Write("Cargando conbustible al motor Disel..");
        }

        public override void Detener()
        {
            Console.Write("Deteniendo el  motor Disel..");
        }
    }
}
