using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Program
    {
        Livro livro;
        public Program()
        {
            livro = new Livro("Aventuras de Alice","Lewis Carroll", 200);
            livro.ExibirInformacoes();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
