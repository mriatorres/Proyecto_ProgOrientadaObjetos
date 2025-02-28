using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Administrador
    {
        public string Correo = "";
        public string Contrasenia = "";

        public Administrador(string correo, string contrasenia)
        {
            correo = this.Correo;
            contrasenia = this.Contrasenia;
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
