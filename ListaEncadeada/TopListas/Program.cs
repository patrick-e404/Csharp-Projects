using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopListas
{
    public class Program
    {
        public Program()
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);

            lista.Exibir();
            lista.Remover((20));
            lista.Exibir();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
