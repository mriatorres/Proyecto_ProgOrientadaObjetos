using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComercioOnline.Administrador_forms.Gestion_rutas;
using VisualComercioOnline.Models;

namespace VisualComercioOnline.Administrador_forms
{
    public partial class ManageRutas : Form
    {
        private static Administrador administradorActual;
        private List<Ruta> rutasActuales; // Lista de rutas


        
        public ManageRutas(Administrador administrador)
        {
            InitializeComponent();
            administradorActual = administrador;
            rutasActuales = RutaManager.Rutas; // Asigna la lista de rutas desde RutaManager

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar ruta
            AgregarRuta agregarRuta = new AgregarRuta(administradorActual);        
           /* if (agregarRuta.ShowDialog() == DialogResult.OK)
            {
                Ruta nuevaRuta = agregarRuta.NuevaRuta;
                // Aquí puedes agregar la nueva ruta a una lista que mantengas en el AdminMenuForm
                // Por ejemplo, si tienes una lista de rutas en el AdminMenuForm:
                rutas.Add(nuevaRuta);
            }*/
            agregarRuta.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Eliminar ruta
            EliminarRuta eliminarRuta = new EliminarRuta();
            eliminarRuta.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Regresar menu
            AdminMenuForm adminmenu = new AdminMenuForm(administradorActual);
            adminmenu.Show();
            this.Close();

        }

       
    }
}
