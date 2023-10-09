using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Herois
{
    public class SuperPoder
    {
        private string nome;
        private int categoria;

        public SuperPoder()
        {
            nome = "";
            categoria = 0;
        }

        public SuperPoder(string nome, int categoria)
        {
            this.nome = nome;
            this.categoria = categoria;
        }

        public string getNome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int getCategoria
        {
            get { return  categoria; }
            set { categoria = value; }
        }
        public void Exibir()
        {
            Console.WriteLine($"O nome do poder é: {nome}");
            Console.WriteLine($"A categoria do poder é: {categoria}");
        }
    }
}
