using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Conductor
    {
        public string Nombre="";
        public string NumeroAutomovil="";
        public Ruta RutaConductor;

        public Conductor(string nombre, string numeroAutomovil, Ruta rutaConductor)
        {
            nombre = this.Nombre;
            numeroAutomovil = this.NumeroAutomovil;
            rutaConductor = this.RutaConductor;
        }
    }
}
