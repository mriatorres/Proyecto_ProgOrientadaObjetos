namespace VisualComercioOnline
{
    public partial class ComercioOnline_SistemaGestion : Form
    {
        public ComercioOnline_SistemaGestion()
        {
            InitializeComponent();
        }

        private void ComercioOnline_SistemaGestion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ComercioOnline_SistemaGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            Application.Exit();
        
        }
    }
}
