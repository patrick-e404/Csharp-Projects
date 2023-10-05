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
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);

            lista.Exibir();
            lista.Remover((20));
            lista.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            int cont = lista.ContarElementos();
            Console.WriteLine($"Numero de elementos: {cont}");
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            bool found = lista.Buscar(20);
            Console.WriteLine(found);
            bool notFound = lista.Buscar(50);
            Console.WriteLine(notFound);
            */
            // --------------------------------------------------------------------------------------- \\
            lista.Inserir(20);
            lista.InserirInicio(10);
            lista.Exibir();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
