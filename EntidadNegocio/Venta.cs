using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadNegocio
{
    class Venta
    {
        public int Master_NroVenta { get; set; }
        private DateTime Fecha { get; set; }

        public List<Detalle> Detalles = new List<Detalle>();
    }

    //public int getTotal()
    //{
    //}
}