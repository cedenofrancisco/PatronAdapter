using System;

namespace PatronAdapter
{
    public abstract class Motor
    {
        public abstract void Acelerar();

        public abstract void Arrancar();

        public abstract void Detener();

        public abstract void CargarCombustible();
    }
}