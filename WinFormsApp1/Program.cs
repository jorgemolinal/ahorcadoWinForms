using WinFormsApp1.Controllers;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            AhorcadoController principal = new AhorcadoController();
            principal.lanzarJuego();

        }
    }
}//definir un modelo, instanciar formulario y pasarlo al controlador
//definir los formularios