using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadNegocio
{
    class Detalle
    {
        public Producto ProductoComprado { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
    }
}