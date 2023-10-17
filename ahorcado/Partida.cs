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
    public partial class Partida : Form
    {

        private List<Char> letrasUtilizadas = new List<Char>();
        private string palabraRecibida;
        private int vidas = 10;



        public Partida(string palabra)
        {
            InitializeComponent();
            palabraRecibida = palabra;
            inicializarPartida();
        }

        private void inicializarPartida()
        {
            palabraLabel.Text = string.Empty; //La vacio primero pq si no pone label1 delante
            for (int i = 0; i < palabraRecibida.Length; i++) //Recorrro la palabra a adivinar
            {
                palabraLabel.Text += "*"; // Muestra guiones bajos y espacio para cada letra
            }
            vidasLabel.Text = "Vidas: " + vidas;
            labelInfo.Text = string.Empty;
        }

        private void buttonProbar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                char letra = char.Parse(textBox1.Text); //Lo convierto en char

                if (!(letrasUtilizadas.Contains(letra))) //Si no me lo han dicho
                {
                    letrasUtilizadas.Add(letra);
                    actualizarPalabra(letra);
                    if (vidas == 0)
                    {
                        labelInfo.Text = "Has perdido, la palabra es " + palabraRecibida;
                    }
                }
                else
                {
                    labelInfo.Text = "Ya habias dicho esta letra";
                }
            }
            else
            {
                labelInfo.Text = "Sólo puedes introducir 1 letra";
            }
        }

        private void actualizarPalabra(char letra)
        {
            bool letraEncontrada = false;
            string palabraAdivinada = palabraLabel.Text; //La palabra con ***

            for (int i = 0; i < palabraRecibida.Length; i++)
            {
                if (palabraRecibida[i] == letra)
                {
                    palabraAdivinada = palabraAdivinada.Remove(i, 1).Insert(i, letra.ToString());
                    letraEncontrada = true;
                    palabraLabel.Text = palabraAdivinada;
                    labelInfo.Text = string.Empty;
                }
            }

            if (!letraEncontrada)
            {
                vidas--;
                vidasLabel.Text = "Vidas: " + vidas;
                labelInfo.Text = $"No contiene la letra {letra}";
            }

            if (palabraAdivinada == palabraRecibida)
            {
                labelInfo.Text = "Has ganado";
                textBox1.Enabled = false;
            }
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
