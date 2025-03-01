using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Conductor
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string NumeroAutomovil{ get; set; }
        public Ruta RutaConductor{ get; set; }

        public Conductor(string id, string nombre, string numeroAutomovil, Ruta rutaConductor)
        {
            ID = id;
            Nombre = nombre;
            NumeroAutomovil = numeroAutomovil;
            RutaConductor = rutaConductor;

        }
    }
}
