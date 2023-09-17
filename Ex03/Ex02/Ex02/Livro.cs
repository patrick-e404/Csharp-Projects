using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex02
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;
        public Livro()
        {
            titulo = string.Empty;
            autor = string.Empty;
            numeroPaginas = 0;
        }
        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Numero de paginas do livro: {numeroPaginas}");
        }
    }
}