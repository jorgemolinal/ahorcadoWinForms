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
    public partial class InicioView : Form
    {
        public event EventHandler<string> button1Click;
        private string name;
        public InicioView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Nombre incorrecto. Es nulo o tiene espacios");
            }
            else
            {
                name = nombre;
                button1Click?.Invoke(sender, name);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
