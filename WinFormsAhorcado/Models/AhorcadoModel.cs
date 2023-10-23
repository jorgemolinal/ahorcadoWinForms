using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAhorcado.Views;

namespace WinFormsAhorcado.Models
{
    public class AhorcadoModel
    {
        public string palabra;
        public string palabraLabel;
        public int vidas;
        private List<char> letrasUtilizadas ;

        public bool hasGanado=false;
        public bool hasPerdido = false;

        public AhorcadoModel(string palabra)
        {
            this.palabra = palabra;
            vidas = 10;
            letrasUtilizadas = new List<char>();
            palabraLabel = getPalabraLabel();
        }


        public bool comprobar(char letra) //true si la encuentra, false si no
        {
            if (!(letrasUtilizadas.Contains(letra))) //Si no me lo han dicho
            {
                letrasUtilizadas.Add(letra);

                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        palabraLabel = palabraLabel.Remove(i, 1).Insert(i, letra.ToString());
                        
                        if (palabraLabel == palabra) { hasGanado = true; };
                
                        return true;

                        //palabraLabel.Text = palabraLabel;
                        
                    }
                }
                vidas--;
                if (vidas == 0) { hasPerdido = true; }
                return false;
            }
            else
            {
                vidas--;
                if (vidas == 0) { hasPerdido = true; }
                return false;
            }
        }

        public int finalPartida () //Devuelve 0 si has ganado y 1 si has perdido, 2 si continuas
        {
            if (hasGanado)
            {
                return 0;
            } else if (hasPerdido)
            {
                return 1;
            } else { return 2; }
        }

        public string getPalabraLabel()
        {
            for (int i = 0; i < palabra.Length; i++) //Recorrro la palabra a adivinar
            {
                palabraLabel += "*"; // Muestra guiones bajos y espacio para cada letra
            }
            return palabraLabel;
        }
        
        public string getLetrasRepetidas()
        {
            string letras = "";
            foreach (char i in letrasUtilizadas)
            {
                letras += i + ", ";
            }
            return letras;
        }
        
    }
}
