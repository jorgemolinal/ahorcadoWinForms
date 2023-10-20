using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAhorcado.Views
{
    public partial class AhorcadoView : Form
    {
        public char letra;
        public event EventHandler buttonProbarClick;
        private string name;
        public AhorcadoView(string palabra, int vidas, string name)
        {
            this.name = name;
            InitializeComponent();
            InicializaPartida(palabra, vidas);
        }
        public void InicializaPartida(string palabra, int vidas)
        {
            palabraLabel.Text = string.Empty;

            for (int i = 0; i < palabra.Length; i++) //Recorrro la palabra a adivinar
            {
                palabraLabel.Text += "*"; // Muestra guiones bajos y espacio para cada letra
            }

            vidasLabel.Text = "Vidas: " + vidas;
            labelInfo.Text = "Hola " + name + ", la palabra es: " + palabra;
        }
        public void ActualizaPalabra(char letra, bool comprobacion, string palabra, int vidas)
        {
            if (comprobacion)
            {
                palabraLabel.Text = palabra;
                labelInfo.Text = string.Empty;
            } else
            {
                vidasLabel.Text = "Vidas: " + vidas;
                labelInfo.Text = "Letra equivocada o repetida";
            }
        }
        private void AhorcadoView_Load(object sender, EventArgs e)
        {

        }

        private void buttonProbar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                letra = char.Parse(textBox1.Text); //Lo convierto en char
                buttonProbarClick?.Invoke(sender, e);
            }
            else
            {
                labelInfo.Text = "Sólo puedes introducir 1 letra";
            }
        }

        private void letrasUtilizadas(List<string> lista)
        {
            foreach (string str in lista)
            {

            }
        }

        public void showFinal(bool hasGanado)
        {
            if (hasGanado)
            {
                labelInfo.Text = "Has ganado!";
            } else
            {
                labelInfo.Text = "Has perdido :(";
            }
        }
    }
}
