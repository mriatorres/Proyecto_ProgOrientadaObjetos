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

            // Validar que se diligencien los inputs
            if (string.IsNullOrWhiteSpace(nombreComprador) || string.IsNullOrWhiteSpace(numruta) || string.IsNullOrWhiteSpace(cantidadTiquetes))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (int.TryParse(cantidadTiquetes, out cantidadTiquetesnum) && int.TryParse(numruta, out numrutaint))
            {
                // Mostrar el número de ruta ingresado y el total de rutas
                //MessageBox.Show($"Número de ruta ingresado: {numrutaint}, Total de rutas: {rutasActuales.Count}");

                // Construir un mensaje con el número de ruta ingresado y cada ruta disponible
                StringBuilder rutasInfo = new StringBuilder($"Ruta ingresada: {numrutaint}\nRutas disponibles:\n");
                for (int i = 0; i < rutasActuales.Count; i++)
                {
                    var ruta = rutasActuales[i];
                    rutasInfo.AppendLine($"Numero de ruta: {i}, Origen: {ruta.Origen}, Destino: {ruta.Destino}");
                }
                // Mostrar las rutas disponibles
                MessageBox.Show(rutasInfo.ToString());

                // Validar si la ruta es valida
                if (numrutaint >= 0 && numrutaint <= rutasActuales.Count)                 
               {
                    // Restar 1 para usar como índice
                    //int rutaIndex = numrutaint - 1;

                    //Try catch block por si ocurre alguna excepcion en la funcion realizar venta
                    try
                    {
                        RegistrarVenta(nombreComprador, numrutaint, cantidadTiquetesnum);
                        CajeroMenuForm cajeromenu = new CajeroMenuForm(cajeroActual);
                        cajeromenu.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al realizar la venta: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Número de ruta no válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo números para el campo número de ruta y la cantidad de tiquetes.");
            }
        }


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
