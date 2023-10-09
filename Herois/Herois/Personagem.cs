using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Herois
{
    public class Personagem
    {
        private string nome;
        private string nomeVidaReal;
        private SuperPoder[] poderes = new SuperPoder[4];

        public Personagem(string nome, string nomeVidaReal)
        {
            this.nome = nome;
            this.nomeVidaReal = nomeVidaReal;
        }

        public void adicionarSuperPoder(SuperPoder sp)
        {
            bool vetorCheio = true;

            for (int i = 0; i < poderes.Length; i++)
            {
                if (poderes[i] == null)
                {
                    vetorCheio = false;
                    break;
                }
            }
            if (vetorCheio)
            {
                Console.WriteLine("O nível maximo de poderes foi atingido.");
                return;
            }
        }
    }
}