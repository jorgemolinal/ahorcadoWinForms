using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class AhorcadoModel
    {
        private List<Char> letrasUtilizadas = new List<Char>();
        private int vidas = 10;
        private List<String> palabras = new List<String>();

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

        public string verPalabraUsar()
        {
            Random r = new Random();
            int palabra = (r.Next(0, 10));
            string PalabraJuego = palabras[palabra].ToLower();
            return PalabraJuego;
        }

        public int GetVidas()
        {
            return vidas;
        }

    }
}
