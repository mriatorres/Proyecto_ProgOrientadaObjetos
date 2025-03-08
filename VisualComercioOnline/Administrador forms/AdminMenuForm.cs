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
    public partial class AdminMenuForm : Form
    {
        private static Administrador administradorActual;

       

        public AdminMenuForm(Administrador administrador)
        {
            InitializeComponent();
            RutaManager.InitializeRutas(); // Inicializa las rutas
            administradorActual = administrador;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gestionar cajeros
            ManageCajerosForm manageCajeros = new ManageCajerosForm(administradorActual);
            manageCajeros.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Gestionar conductores
            ManageConductoresForm manageConductoresForm = new ManageConductoresForm();
            manageConductoresForm.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cerrar sesión
            ComercioOnline_SistemaGestion form1 = new ComercioOnline_SistemaGestion();
            form1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Gestionar rutas
            ManageRutas managerutas = new ManageRutas(administradorActual);
            managerutas.Show();
            this.Close();
        }

      

        
    }
}
