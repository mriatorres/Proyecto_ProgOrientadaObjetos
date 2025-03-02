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

namespace VisualComercioOnline
{
    public partial class CambiarUsuario : Form

    {
        
        // Campo para almacenar el cajero actual
        private Cajero cajeroActual;


        public CambiarUsuario(Cajero cajero) //Se le envio cuando se llamo el metodo en MenuFrom
        {
            InitializeComponent();
            cajeroActual = cajero; // Asigna el cajero pasado al constructor
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cambiar nombre usuario
            CambiarNombreUsuario(cajeroActual);
            this.Close();
            CajeroMenuForm cajeroMenu = new CajeroMenuForm(cajeroActual);
            cajeroMenu.Show();
            /*CambiarNombreUsuario(cajeroActual);
            this.Hide();
            CajeroMenuForm cajeroMenu = new CajeroMenuForm(cajeroActual);
            cajeroMenu.ShowDialog();
            // We get here when newform's DialogResult gets set
            this.Show();*/



        }

        private void CambiarNombreUsuario(Cajero cajero)
        {
            //Console.Write("Ingrese el nuevo nombre de usuario: ");
            //string nuevoNombre = Console.ReadLine();
            string nuevoNombre = txtEmail.Text;

            if (nuevoNombre.Length > 0)
            {
                cajero.Nombre = nuevoNombre;
                MessageBox.Show("Nombre de usuario cambiado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre usuario");
               // return; // Sale del metodo si no se ingresa un nuevo nombre de usuario
            }
            
            //Console.WriteLine("Nombre de usuario cambiado correctamente.");
        }

    }
}
