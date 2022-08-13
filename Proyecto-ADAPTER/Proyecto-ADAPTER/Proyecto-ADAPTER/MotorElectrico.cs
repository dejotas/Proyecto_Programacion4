using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADAPTER
{
    public class MotorElectrico 
    {
        bool _conectado;
        bool _activo;
        bool _moviendo;

        public void Conectar()
        {
            if(_conectado)
                Console.Write("Imposible conectar un motor electrico ya conectado");
            else
            {
                _conectado = true;
                Console.WriteLine("MOTOR CONECTADO!");
            }
        }

        public void Activar()
        {
            if (!_conectado)
                Console.Write("Imposible activar un motor no conectado");
            else
            {
                _activo = true;
                Console.WriteLine("motor activado!");
            }
        }

        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }
                
            else
            {                
                Console.WriteLine("El motor debera estar conectado y activo");
            }
        }

       public void Parar()
        {
            if(_moviendo)
            {
                _moviendo=false;
                Console.WriteLine("Parar el vehiculo con motor electrico...");
            }
            else
            {
                Console.WriteLine("Imposible parar un motor que no este en movimiento");
            }
        }

        public void Desconectar()
        {
            if (_conectado)
            {                
                Console.WriteLine("Motor desacticado...");
            }
            else
            {
                Console.WriteLine("Imposible desconectar un motor que no este conectado");
            }
        }

        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor desactivado");
            }
            else
            {
                Console.WriteLine("Imposible desactivar un motor que no esté activo");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo=false;
                Console.WriteLine("Motor cargando las baterias!...");
            }
            else
            {
                Console.WriteLine("Imposible enchufar un motor activo!");
            }
        }

    }
}
