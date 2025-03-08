using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualComercioOnline.Models;

namespace VisualComercioOnline.Administrador_forms
{
    public static class RutaManager
    {
        public static List<Ruta> Rutas { get; private set; } = new List<Ruta>();

        public static void InitializeRutas()
        {
            Rutas.Add(new Ruta(1, "Homecenter", "Destino1", "Horario1", 23, 18, 10000));
            Rutas.Add(new Ruta(2, "IKEA", "Destino2", "Horario2", 25, 15, 20000));
        }
    }
}
