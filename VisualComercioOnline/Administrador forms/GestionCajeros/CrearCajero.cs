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

namespace VisualComercioOnline.Administrador_forms.GestionCajeros
{
    public partial class CrearCajero : Form
    {
        private List<Cajero> cajeros;
        private static Administrador administradorActual;

        public CrearCajero(Administrador administrador)
        {
            InitializeComponent();
            InitializeCajeros(); //Inicializar lista cajeros
            administradorActual = administrador;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar cajero nuevo
            crearNuevoCajero();

            ManageCajerosForm manageCajerosForm = new ManageCajerosForm(administradorActual);
            manageCajerosForm.Show();
            this.Close();


        }

        private void crearNuevoCajero()
        {
            // Obtener los datos del formulario y eliminar espacios en blanco
            string idCajeroText = txtId.Text.Trim();
            string numTrabajText = txtNumT.Text.Trim();
            string correoCajero = txtEmail.Text.Trim();
            string pwdCajero = txtPwd.Text.Trim();
            string nameCajero = txtName.Text.Trim();

            // Verificar que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(idCajeroText) &&
                !string.IsNullOrWhiteSpace(numTrabajText) &&
                !string.IsNullOrWhiteSpace(correoCajero) &&
                !string.IsNullOrWhiteSpace(pwdCajero) &&
                !string.IsNullOrWhiteSpace(nameCajero))
            {
                // Convertir los textos a enteros
                if (int.TryParse(idCajeroText, out int idCajero) &&
                    int.TryParse(numTrabajText, out int numTrabaj))
                {
                    // Crear un nuevo Cajero
                    Cajero nuevoCajero = new Cajero(idCajero, numTrabaj, correoCajero, pwdCajero, nameCajero);
                    cajeros.Add(nuevoCajero); // Agregar el nuevo cajero a la lista

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Se creó el nuevo cajero de forma exitosa!");
                }
                else
                {
                    // Mostrar mensaje de error si la conversión falla
                    MessageBox.Show("El ID y el número de trabajador deben ser números válidos.");
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese todos los datos necesarios...");
            }
        }


        private void InitializeCajeros()
        {
            // Initialize the list of cajeros
            cajeros = new List<Cajero>
            {
                new Cajero(1, 101, "rafael@ejemplo.com", "rafael123", "Rafael"),
                new Cajero(2, 102, "sandra@ejemplo.com", "sandra123", "Sandra")
            };
        }

        
    }
}
