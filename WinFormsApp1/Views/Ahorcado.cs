using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1
{
    public partial class Ahorcado : Form
    {

        private List<Char> letrasUtilizadas = new List<Char>();
        private string palabraRecibida;



        public Ahorcado(string palabra)
        {
            InitializeComponent();
            palabraRecibida = palabra;
            AhorcadoController ahorcadoController = new AhorcadoController();
            inicializarPartida(ahorcadoController);
        }

        private void inicializarPartida(AhorcadoController ahorcadoController)
        {
            //Pinto la vista
            palabraLabel.Text = string.Empty;
            for (int i = 0; i < palabraRecibida.Length; i++) 
            {
                palabraLabel.Text += "*"; 
            }
            int vidas = ahorcadoController.GetVidas();
            vidasLabel.Text = "Vidas: " + vidas;
            labelInfo.Text = string.Empty;
        }

        public bool probar = false;
        private void buttonProbar_Click(object sender, EventArgs e)
        {
            probar = true;
            probarTrue();
            probar = false;

           /* if (textBox1.Text.Length == 1)
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
            } */
        }
        public bool probarTrue()
        {
            return probar;
        }

        private void actualizarPalabra(char letra)
        {
            bool letraEncontrada = false;
            string palabraAdivinada = palabraLabel.Text; //La palabra con ***

            for (int i = 0; i < palabraRecibida.Length; i++) //Pintar la palabra con *
            {
                if (palabraRecibida[i] == letra)
                {
                    palabraAdivinada = palabraAdivinada.Remove(i, 1).Insert(i, letra.ToString());
                    letraEncontrada = true;
                    palabraLabel.Text = palabraAdivinada;
                }
            }

            if (!letraEncontrada)
            {
                vidas--;
                vidasLabel.Text = "Vidas: " + vidas;
            }

            if (palabraAdivinada == palabraRecibida)
            {
                labelInfo.Text = "Has ganado";
                textBox1.Enabled = false;
            }
        }
    }
}
