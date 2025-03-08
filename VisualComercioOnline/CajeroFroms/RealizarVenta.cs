using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComercioOnline.Administrador_forms;
using VisualComercioOnline.Models;

namespace VisualComercioOnline
{
    public partial class RealizarVenta : Form
    {
        private Cajero cajeroActual; //Cajero loggeado
        private List<Ruta> rutasActuales; // Lista de rutas



        public RealizarVenta(Cajero cajero)
        {
            InitializeComponent();
            cajeroActual = cajero; // Asigna el cajero actual
            rutasActuales = RutaManager.Rutas; // Asigna la lista de rutas desde RutaManager

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreComprador = txtNomComp.Text;
            string numruta = txtNumRuta.Text;
            string cantidadTiquetes = txtCantidadTiquetes.Text;
            int cantidadTiquetesnum;
            int numrutaint;
            if (int.TryParse(cantidadTiquetes, out cantidadTiquetesnum) && int.TryParse(numruta, out numrutaint))
            {
                // Revisar si la ruta seleccionada es valida
                if (numrutaint >= 0 && numrutaint < rutasActuales.Count)
                {
                    RegistrarVenta(nombreComprador, numrutaint, cantidadTiquetesnum);
                }
                else
                {
                    Console.WriteLine("Número de ruta no válido.");
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo numeros para el campo numero de ruta y la cantidad de tiquetes");
            }

        }

        /* private void InitializeRutas()
         {
             // Inicializa la lista de rutas (llamada al principio del archivo)
             rutas = new List<Ruta>();
             {
                 rutas.Add(new Ruta(1, "Homecenter", "Destino1", "Horario1", 23, 18, 10000));
                 rutas.Add(new Ruta(2, "IKEA", "Destino2", "Horario2", 25, 15, 20000));
             }

         }*/

        private void RegistrarVenta(string nombreComprador, int numRuta, int cantidadTiquetes)
        {
            // Precio por tiquete de la ruta seleccionada
            int precioPorTiquete = rutasActuales[numRuta].PrecioTiquete;
            int totalPrecio = precioPorTiquete * cantidadTiquetes;

            // Crear la factura
            Factura factura = new Factura(numRuta + 1, cantidadTiquetes, totalPrecio);

            // Realizar la venta con el cajero autenticado
            cajeroActual.RealizarVenta(factura);

            // Mostrar compra al usuario
            MessageBox.Show($"Venta realizada con éxito!\n Comprador: {nombreComprador}\nRuta: {rutasActuales[numRuta].Origen} hacia {rutasActuales[numRuta].Destino}\nCantidad Tiquetes: {cantidadTiquetes}\nTotal a pagar: {totalPrecio:C}");
        }

        private void RealizarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
