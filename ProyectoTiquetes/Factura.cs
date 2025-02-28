using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Factura
    {
        public int CantidadTiquetes;
        public float PrecioTotal;
        public int NumeroPedido;

        public Factura(int numeroPedido, int cantidadTiquetes, float precioTotal)
        {
            numeroPedido = this.NumeroPedido;
            cantidadTiquetes = this.CantidadTiquetes;
            precioTotal = this.PrecioTotal;
        }
    }
}

