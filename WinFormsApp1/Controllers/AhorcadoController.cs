using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    internal class AhorcadoController
    {
        private AhorcadoModel ahorcadoModel;
        private Ahorcado ahorcadoView;
        public AhorcadoController(Ahorcado ahorcadoView)
        {
            ahorcadoModel = new AhorcadoModel();
            this.ahorcadoView = ahorcadoView;
        }
        public void lanzarJuego()
        {
            string PalabraJuego = ahorcadoModel.verPalabraUsar();

            Application.Run(new Ahorcado(PalabraJuego));
        }

        public int GetVidas()
        {
            int vidas = ahorcadoModel.GetVidas();
            return vidas;
        }
        public void buttonProbar()
        {
            ahorcadoView.probarTrue();
        }
    }
}
