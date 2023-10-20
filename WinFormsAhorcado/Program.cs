using WinFormsAhorcado.Views;
using WinFormsAhorcado.Controllers;

namespace WinFormsAhorcado
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InicioView view = new InicioView();

            InicioContoller inicioController = new InicioContoller(view);
            inicioController.Arrancar();

        }
    }
}