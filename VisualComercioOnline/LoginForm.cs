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
    public partial class LoginForm : Form
    {
        // Lista para guardar cajeros
        private List<Cajero> cajeros;
        // Variable para almacenar el cajero autenticado
        private static Cajero cajeroActual { get; set; }
        //Almacenar administrador
        private static Administrador administrador;

        public LoginForm()
        {
            InitializeComponent();
            InitializeCajeros(); // Inicializa la lista de cajeros

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Implementar logica de autenticacion
            string correo = txtEmail.Text;
            string contraseña = txtPassword.Text;

            // Revisa si cmbRole.SelectedItem es nulo
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol.");
                return; // Sale del metodo si ningun rol es seleccionado
            }

            string rol = cmbRole.SelectedItem.ToString();

            // Revisa si las credenciales son correctas y abre el menu apropiado
            if (IsValidAdmin(correo, contraseña, rol))
            {
                AdminMenuForm adminMenu = new AdminMenuForm(administrador);
                adminMenu.Show();
                this.Hide();
            }
            else if (IsValidCajero(correo, contraseña, rol))
            {
                CajeroMenuForm cajeroMenu = new CajeroMenuForm(cajeroActual);
                cajeroMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Intente nuevamente.");
            }
        }

        private bool IsValidAdmin(string correo, string contraseña, string rol)
        {
            // Valida las credenciales de admin
            return (correo == "Andreni@ejemplo.com" && contraseña == "admin123" && rol == "Administrador");
            
            
        }

        private bool IsValidCajero(string correo, string contraseña, string rol)
        {
            // Valida las credenciales de cajero
            if (rol.Equals("Cajero", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var cajero in cajeros)
                {
                    if (cajero.Correo.Equals(correo, StringComparison.OrdinalIgnoreCase) &&
                        cajero.Contrasenia.Equals(contraseña))
                    {
                        cajeroActual = cajero;
                        return true; //Se encontro cajero valido
                    }
                }
            }
            return false; //No se encontro cajero valido
        }

        private void InitializeCajeros()
        {
            // Inicializa la lista de cajeros (llamada al principio del archivo)
            cajeros = new List<Cajero>
            {
                new Cajero(1, 101, "rafael@ejemplo.com", "rafael123", "Rafael"),
                new Cajero(2, 102, "sandra@ejemplo.com", "sandra123", "Sandra")
            };
        }
        /*private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/
    }
}
