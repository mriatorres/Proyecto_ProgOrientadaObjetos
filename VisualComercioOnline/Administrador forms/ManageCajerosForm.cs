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
using VisualComercioOnline.Administrador_forms.GestionCajeros;
using VisualComercioOnline.Models;

namespace VisualComercioOnline
{
    public partial class ManageCajerosForm : Form
    {
        private static Administrador administradorActual;





        public ManageCajerosForm(Administrador administrador)
        {
            InitializeComponent();
            administradorActual = administrador;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear Cajero
            CrearCajero crearcajero = new CrearCajero(administradorActual);
            crearcajero.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editar cajero
            EditarCajero editarCajero = new EditarCajero();
            editarCajero.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ver lista cajeros
            VerCajeros vercajeros = new VerCajeros();
            vercajeros.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Regresar
            AdminMenuForm adminmenu = new AdminMenuForm(administradorActual);
            adminmenu.Show();
            this.Close();


        }


    }
}
