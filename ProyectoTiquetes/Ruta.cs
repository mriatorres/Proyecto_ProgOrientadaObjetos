using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Ruta
    {
        public int IdRuta;
        public string Origen="";
        public string Destino = "";
        public string Horario = "";
        public int NumTiquetesDisponibles;
        public int NumTiquetesVendidos;

        public Ruta(int idRuta, string origen, string destino, string horario, int numTiquetesDisponibles, int numTiquetesVendidos)
        {
            idRuta = this.IdRuta;
            origen = this.Origen;
            destino = this.Destino; 
            horario = this.Horario; 
            numTiquetesDisponibles = this.NumTiquetesDisponibles;
            numTiquetesVendidos = this.NumTiquetesVendidos;
        }
    }
}
