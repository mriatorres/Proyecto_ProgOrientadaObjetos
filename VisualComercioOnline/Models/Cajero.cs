using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComercioOnline.Models
{
    public class Cajero
    {
        public int ID { get; set; }
        public int NumTrabajador { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }

        public Cajero(int id, int numTrabajador, string correo, string contrasenia, string nombre)
        {
            ID = id;
            NumTrabajador = numTrabajador;
            Correo = correo;
            Contrasenia = contrasenia;
            Nombre = nombre;
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
