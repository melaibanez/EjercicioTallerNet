using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadNegocio
{
    class Detalle
    {
        public Producto Master_ProductoComprado { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
    }
}