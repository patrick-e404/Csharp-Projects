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
            /*
            lista.Inserir(20);
            lista.InserirInicio(10);
            lista.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inverter();
            lista.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            ListaEncadeada lista1 = new ListaEncadeada();
            lista1.Inserir(10);
            lista1.Inserir(20);
            ListaEncadeada lista2 = new ListaEncadeada();
            lista1.Inserir(30);
            lista1.Inserir(40);
            lista1.Concatena(lista2);
            lista1.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(10);
            lista.Inserir(30);
            lista.RemoverDuplo();
            lista.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            ListaEncadeada lista1 = new ListaEncadeada();
            lista1.Inserir(10);
            lista1.Inserir(20);
            lista1.Inserir(30);
            ListaEncadeada lista2 = new ListaEncadeada();
            lista2.Inserir(20);
            lista2.Inserir(30);
            lista2.Inserir(40);
            ListaEncadeada intersecao = lista1.Intersecao(lista2);
            intersecao.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            /*
            lista.Inserir(30);
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Ordenar();
            lista.Exibir();
            */
            // --------------------------------------------------------------------------------------- \\
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(40);
            ListaEncadeada[] listaDivididos = lista.Dividir();
            listaDivididos[0].Exibir();
            listaDivididos[1].Exibir();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
