using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Juego : Form
    {        
        
        private List<Char> letrasUsuario = new List<Char>();
        private List<String> palabras = new List<String>();
        
        public Juego()
        {
            InitializeComponent();
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

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            RellenarListPalabras();
            string PalabraJuego = verPalabraUsar();

            Partida partida = new Partida(PalabraJuego);
            partida.Show();
        }

        private string verPalabraUsar()
        {
            Random r = new Random();
            int palabra = (r.Next(0, 10));
            string PalabraJuego = palabras[palabra].ToLower();
            return PalabraJuego;
        }
    }
}
