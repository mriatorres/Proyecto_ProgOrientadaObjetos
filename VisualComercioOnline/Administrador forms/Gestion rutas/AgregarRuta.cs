using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComercioOnline.Models;

namespace VisualComercioOnline.Administrador_forms.Gestion_rutas
{
    public partial class AgregarRuta : Form
    {

        private static Administrador administradorActual;

        private List<Ruta> rutasActuales; // Lista de rutas

        public AgregarRuta(Administrador administrador)
        {
            InitializeComponent();
            administradorActual = administrador;
            txtHora.KeyPress += new KeyPressEventHandler(txtHora_KeyPress);
            txtHora.Leave += new EventHandler(txtHora_Leave);

            rutasActuales = RutaManager.Rutas; // Asigna la lista de rutas desde RutaManager
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // FORMATO HORARIO INICIO

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, dos puntos, espacios y letras (A, P)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != ' ' && e.KeyChar != 'A' && e.KeyChar != 'P' && e.KeyChar != 'M')
            {
                e.Handled = true; // Suprimir la entrada
            }
        }

        private void txtHora_Leave(object sender, EventArgs e)
        {
            // Validar el formato de la hora
            if (!IsValidTimeFormat(txtHora.Text))
            {
                MessageBox.Show("Por favor, ingrese un horario válido en el formato HH:MM AM/PM.");
                txtHora.Focus(); // Regresar el foco al TextBox
            }
        }

        private bool IsValidTimeFormat(string time)
        {
            // Expresión regular para validar el formato de hora
            string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] ?[AP]M$";
            return System.Text.RegularExpressions.Regex.IsMatch(time, pattern);
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarRuta_Click(object sender, EventArgs e)
        {
            string idruta = txtIdruta.Text;
            int idrutaint;
            string origen = txtOrigen.Text.Trim();
            string destino = txtDestino.Text.Trim();
            string horario = txtHora.Text;
            string precioTiquete = txtPrecioTiquete.Text;
            int precioTiqueteint;

            string tiquetesDisponibles = txtTiquetesDispo.Text;
            int tiquetesDispoint;

            int tiquetesVendidios = 0;

            if (origen.Length  > 1 && destino.Length > 1) {
                if(int.TryParse(precioTiquete, out precioTiqueteint) && int.TryParse(tiquetesDisponibles, out tiquetesDispoint) && int.TryParse(idruta, out idrutaint))
                {
                    AgregarRutaNueva(idrutaint,origen,destino,horario,tiquetesDispoint,tiquetesVendidios,precioTiqueteint);
                    MessageBox.Show("Ruta nueva agregada con exito!");
                    ManageRutas managerutas = new ManageRutas(administradorActual);
                    managerutas.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numericos para ID ruta, tiquetes disponibles, precio tiquete...");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingese un destino y un origen, asegurese de que ingrese más de un caracter");
            }


               
        }

        private void AgregarRutaNueva(int idruta, string origen, string destino, string horario, int tiquetesDisponibles, int tiquetesVendidos, int precioTiquete)
        {
            rutasActuales.Add(new Ruta(idruta, origen, destino, horario, tiquetesDisponibles, tiquetesVendidos, precioTiquete));
        }
        
    }
}
