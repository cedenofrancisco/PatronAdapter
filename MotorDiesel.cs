using System;

namespace PatronAdapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("***Acelerando el motor Diesel***");
        }

        public override void Arrancar()
        {
            Console.WriteLine("***Arrancando el motor Diesel***");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("***Cargando combustible al motor Diesel***");
        }

        public override void Detener()
        {
            Console.WriteLine("***Deteniendo el motor Diesel***");
        }
    }
}