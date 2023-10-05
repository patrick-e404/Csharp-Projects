using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopListas
{
    public class ListaEncadeada
    {
        private Nodo _Raiz;

        public void Inserir(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_Raiz == null)
            {
                _Raiz = novoNodo;
                return;
            }
            Nodo nodo = _Raiz;

            while (nodo.Proximo != null)
            {
                nodo = nodo.Proximo;
            }
            nodo.Proximo = novoNodo;
        }
        public void Exibir()
        {
            if (_Raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            Console.Write(_Raiz.Conteudo);
            Nodo nodo = _Raiz.Proximo;

            while (nodo != null)
            {
                Console.Write($"/ {nodo.Conteudo}");
                nodo = nodo.Proximo;
            }
            Console.WriteLine("");
        }
    }
}
