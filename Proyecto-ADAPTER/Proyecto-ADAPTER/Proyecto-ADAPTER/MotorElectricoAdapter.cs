using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADAPTER
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new MotorElectrico();
        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }

        public override void CargarConbustible()
        {
            motorElectrico.Enchufar();
        }

        public override void Detener()
        {
            motorElectrico.Desconectar();
            motorElectrico.Parar();
        }
    }
}
