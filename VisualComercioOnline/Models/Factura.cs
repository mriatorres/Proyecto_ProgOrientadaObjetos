using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComercioOnline.Models
{
    public class Factura
    {
        public int CantidadTiquetes { get; set; }
        public int PrecioTotal { get; set; }
        public int NumeroPedido { get; set; }

        public Factura(int numeroPedido, int cantidadTiquetes, int precioTotal)
        {
            CantidadTiquetes = cantidadTiquetes;
            PrecioTotal = precioTotal;
            NumeroPedido = numeroPedido;
        }
    }
}
