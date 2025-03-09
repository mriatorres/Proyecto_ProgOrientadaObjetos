using VisualComercioOnline.Administrador_forms;

namespace VisualComercioOnline
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            /*
             LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
             */

            RutaManager.InitializeRutas();

            ComercioOnline_SistemaGestion form1 = new ComercioOnline_SistemaGestion();
            form1.ShowDialog(); //App no depende de form1
            Application.Run();
        }
    }
}