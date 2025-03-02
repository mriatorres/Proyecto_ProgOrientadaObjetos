using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComercioOnline.Models
{
    public class Administrador
    {
        public string Correo { get; private set; }
        public string Contrasenia { get; private set; }

        public Administrador(string correo, string contrasenia)
        {
            Correo = correo;
            Contrasenia = contrasenia;
        }

        public void GestionarCuenta()
        {
            Console.WriteLine("\n--- Gestión cuenta administrador ---");
            Console.Write("Ingrese el nuevo usuario: ");
            Correo = Console.ReadLine();
            Console.Write("Ingrese la nueva contraseña: ");
            Contrasenia = Console.ReadLine();
            Console.WriteLine("Cuenta del administrador actualizada correctamente.");
        }

        public string ObtenerContrasenia() // Método para acceder a la contraseña

        {
            return Contrasenia;
        }
    }
}
