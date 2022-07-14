using System;

namespace PatronAdapter
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("---Acelerando el motor Naftero---");
        }

        public override void Arrancar()
        {
            Console.WriteLine("---Arrancando el motor Naftero---");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("---Cargando combustible al motor Naftero---");
        }

        public override void Detener()
        {
            Console.WriteLine("---Deteniendo el motor Nadtero---");
        }
    }
}