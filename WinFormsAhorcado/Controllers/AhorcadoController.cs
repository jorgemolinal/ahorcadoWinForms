using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAhorcado.Models;
using WinFormsAhorcado.Views;

namespace WinFormsAhorcado.Controllers
{
    public class AhorcadoController
    {
        AhorcadoModel Ahorcado;
        public AhorcadoView view;
        private List<String> palabras;
        public string palabra;
        public string nombre;

        public AhorcadoController(string name)
        {
            palabras = new List<String>();
            RellenarListPalabras();
            palabra = verPalabraUsar();
            Ahorcado = new AhorcadoModel(palabra);
            view = new AhorcadoView(palabra, Ahorcado.vidas, name);

            view.buttonProbarClick += CompruebaLetra;
            this.nombre = name;
            ShowAhorcado();
        }

        private void RellenarListPalabras()
        {
            palabras.Add("Windows");
            palabras.Add("Aplicacion");
            palabras.Add("Programacion");
            palabras.Add("Ordenador");
            palabras.Add("C++");
            palabras.Add("logica");
            palabras.Add("archivos");
            palabras.Add("Clases");
            palabras.Add("Interfaz");
            palabras.Add("Botones");

        }

        private string verPalabraUsar()
        {
            Random r = new Random();
            int palabra = (r.Next(0, 10));
            string PalabraJuego = palabras[palabra].ToLower();
            return PalabraJuego;
        }
        public void CompruebaLetra(object sender, EventArgs e)
        {
            if (Ahorcado.finalPartida() == 2)
            {
                var letra = view.letra;

                bool comprobacion = Ahorcado.comprobar(letra); //cada vez que compruebo miro finalPartida

                string palabraPintar = Ahorcado.palabraLabel;
                int vidas = Ahorcado.vidas;

                view.ActualizaPalabra(letrasUtilizadas(), comprobacion, palabraPintar, vidas);
            }
            else if (Ahorcado.finalPartida() == 0)
            {
                view.showFinal(true);
            } else
            {
                view.showFinal(false);
            }
        }

        public string letrasUtilizadas()
        {
            return Ahorcado.getLetrasRepetidas();
        }

        private void ShowAhorcado()
        {
            view.Show();
        }
    }
}
