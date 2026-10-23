using System;
using System.Collections.Generic;
using System.Text;

namespace examen_2
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
