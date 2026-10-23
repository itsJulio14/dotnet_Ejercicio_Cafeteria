using System;
using System.Collections.Generic;
using System.Text;

namespace examen_2
{
    internal class Pedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public bool ParaLlevar { get; set; }
        public decimal Subtotal { get; set; }

        public Pedido(Producto producto, int cantidad, bool paraLlevar)
        {
            Producto = producto;
            Cantidad = cantidad;
            ParaLlevar = paraLlevar;

            decimal cargoExtra = 0;
            if (paraLlevar == true)
            {
                cargoExtra = 5;
            }

            Subtotal = (producto.Precio * cantidad) + cargoExtra;
        }
    }


}

