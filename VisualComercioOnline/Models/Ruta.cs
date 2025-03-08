using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComercioOnline.Models
{
    public class Ruta
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Horario { get; set; }
        public int NumTiquetesDisponibles { get; set; }
        public int NumTiquetesVendidos { get; set; }
        public int PrecioTiquete { get; set; }

        public Ruta(int idRuta, string origen, string destino, string horario, int numTiquetesDisponibles, int numTiquetesVendidos, int precioTiquete)
        {
            IdRuta = idRuta;
            Origen = origen;
            Destino = destino;
            Horario = horario;
            NumTiquetesDisponibles = numTiquetesDisponibles;
            NumTiquetesVendidos = numTiquetesVendidos;
            PrecioTiquete = precioTiquete;
        }
    }
}
