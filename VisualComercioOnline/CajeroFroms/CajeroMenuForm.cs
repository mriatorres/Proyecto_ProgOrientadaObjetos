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

    public partial class CajeroMenuForm : Form
    {
        // Campo para almacenar el cajero actual
        private Cajero cajeroActual;

        
        public CajeroMenuForm(Cajero cajero)
        {
            InitializeComponent();
            cajeroActual = cajero; // Asigna el cajero pasado al constructor
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Cambiar nombre*/
            //Pasar el cajeroActual al formulario CambiarUsuario
            CambiarUsuario cambiarUsuario = new CambiarUsuario(cajeroActual);
            cambiarUsuario.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Cambiar contraseña*/
            CambiarContrasenia cambiarContrasenia = new CambiarContrasenia();
            cambiarContrasenia.Show();
            this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Realizar venta*/
            RealizarVenta realizarVenta = new RealizarVenta(cajeroActual);
            realizarVenta.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Cerrar sesión*/

            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Close();
            
            /*ComercioOnline_SistemaGestion form1 = new ComercioOnline_SistemaGestion();
            form1.Show();
            this.Close();*/

        }

        /*private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/

       /* private void CambiarNombreUsuario(Cajero cajero)
        {
            /*Console.Write("Ingrese el nuevo nombre de usuario: ");
            string nuevoNombre = Console.ReadLine();
            cajero.Nombre = nuevoNombre;
            Console.WriteLine("Nombre de usuario cambiado correctamente.");*/
       // }*/
    }
}
