using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadNegocio
{
    class Venta
    {
        private int NroVenta { get; set; }
        private DateTime Fecha { get; set; }

        private List<Detalle> Detalles = new List<Detalle>();
    }

    //public int getTotal()
    //{
    //}
}