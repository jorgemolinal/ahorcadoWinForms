using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAhorcado.Views;

namespace WinFormsAhorcado.Controllers
{
    internal class InicioContoller
    {

        private InicioView view;

        public InicioContoller(InicioView inicioView)
        {
            view = inicioView;
            view.button1Click += EmpiezaJuego;
        }
        
        public void Arrancar()
        {
            Application.Run(view);
        }

        public void EmpiezaJuego(object sender, string e)
        {
            AhorcadoController ahorcadoContoller = new AhorcadoController(e);
        }
    }
}
