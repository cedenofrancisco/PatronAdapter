using System;

namespace PatronAdapter
{
    public class MotorElectrico
    {
        bool _estaconectado;
        bool _estaactivado;
        bool _moviendose;

        public void Conectar()
        {
            if (_estaconectado)
            Console.WriteLine("No se puede conectar un motor electrico ya conectado");
            else {
                _estaconectado= true;
                Console.WriteLine("Motor Conectado");
            }
        }

        public void Activar()
        {
            if (!_estaconectado)
            Console.WriteLine("No se puede activar un motor no conectado");
            else {
                _estaactivado= true;
                Console.WriteLine("Motor Activado");
            }
        }

        public void Mover()
        {
            if (_estaconectado && _estaactivado)
            {
                _moviendose= true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }
            else 
            {
                Console.WriteLine("El motor tiene que esta conectado y activo para moverse");
            }
        }

        public void Parar()
        {
            if(_moviendose)
            {
                _moviendose=false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("No se puede parar un vehiculo que no esta en movimiento");
            }
        }

        public void Desconectar()
        {
            if(_estaconectado)
            {
                Console.WriteLine("Desconectando el motor");
            }
            else 
            {
                Console.WriteLine("No se puede desconectar un motor que no esta conectado");
            }
        }

        public void Desactivar()
        {
            if (_estaactivado)
            {
                _estaactivado = false;
                Console.WriteLine("Motor desactivado...");
            }
            else
            {
                Console.WriteLine("Imposible desactivar un motor que no esté activo!");
            }
        }

        public void Enchufar()
        {
            if (!_estaactivado)
            {
                _estaactivado = false;
                Console.WriteLine("Motor cargando las baterias!...");
            }
            else
            {
                Console.WriteLine("Imposible enchufar un motor activo!");
            }
         
        }
    }
}