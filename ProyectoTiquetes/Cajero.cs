using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiquetes
{
    public class Cajero
    {
        public int ID;
        public int NumTrabajador;
        public string Contrasenia = "";
        protected string Correo ="";
        public string Nombre = "";

        public Cajero(int id, int numTrabajador, string correo, string contrasenia, string nombre)
        {
            id = this.ID;
            numTrabajador = this.NumTrabajador;
            correo = this.Correo;
            contrasenia = this.Contrasenia;
            nombre = this.Nombre;
        }

        public void GestionarCuenta()
        {
            Console.WriteLine("\n--- Gestión cuenta cajero ---");
            Console.Write("Ingrese el nuevo usuario: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese la nueva contraseña: ");
            Contrasenia = Console.ReadLine();
            Console.WriteLine("Cuenta del cajero actualizada correctamente.");
        }

        public void RealizarVenta(Factura factura)
        {
            Console.WriteLine($"Venta realizada: {factura.CantidadTiquetes} tiquetes a {factura.NumeroPedido}.");
        }

        public string ObtenerContrasenia()

        {

            return Contrasenia;

        }
    }
}
