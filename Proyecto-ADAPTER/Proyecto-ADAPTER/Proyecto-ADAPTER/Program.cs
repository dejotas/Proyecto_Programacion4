using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADAPTER
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new MotorNaftero();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Detener();
            motor1.CargarConbustible();

            Motor motor2 = new MotorDisel();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Detener();
            motor2.CargarConbustible();

            Motor motor3 = new MotorElectricoAdapter();
            motor3.Arrancar();
            motor3.Acelerar();
            motor3.Detener();
            motor3.CargarConbustible();

            Console.ReadKey();
        }
    }
}