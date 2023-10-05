using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TopListas
{
    public class ListaEncadeada
    {
        private Nodo _Raiz;

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
                Console.Write($" / {nodo.Conteudo}");
                nodo = nodo.Proximo;
            }
            Console.WriteLine("");
        }
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
        public void Remover(int valor)
        {
            if (_Raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            if (_Raiz.Conteudo == valor)
            {
                _Raiz = _Raiz.Proximo;
                return;
            }
            Nodo nodoAnter = null;
            Nodo nodoAtual = _Raiz;
            
            while (nodoAtual != null && nodoAtual.Conteudo != valor)
            {
                nodoAnter = nodoAtual;
                nodoAtual = nodoAtual.Proximo;
            }

            if (nodoAtual == null)
            {
                Console.WriteLine("Valor não encontrado na lista.");
                return;
            }
            nodoAnter.Proximo = nodoAtual.Proximo;
        }
        public int ContarElementos()
        {
            int contador = 0;
            Nodo nodo = _Raiz;

            while (nodo != null)
            {
                contador++;
                nodo = nodo.Proximo;
            }
            return contador;
        }
        public bool Buscar(int valor)
        {
            Nodo nodo = _Raiz;

            do
            {
                if (nodo.Conteudo == valor)
                {
                    return true;
                }
                nodo = nodo.Proximo;
            }
            while (nodo != null);
            return false;
        }
        public void InserirInicio(int valor)
        {
            Nodo novoNodo = new Nodo(valor);
            novoNodo.Proximo = _Raiz;
            _Raiz = novoNodo;
        }
        public void Inverter()
        {
            Nodo nodoAtual = _Raiz;
            Nodo nodoAnter = null;
            Nodo nodoProximo = null;

            while (nodoAtual != null)
            {
                nodoProximo = nodoAtual.Proximo;
                nodoAtual.Proximo = nodoAnter;

                nodoAnter = nodoAtual;
                nodoAtual = nodoProximo;
            }
            _Raiz = nodoAnter;
        }
        public Nodo ultimoNodo()
        {
            if (_Raiz == null)
            {
                return null;
            }
            Nodo nodo = _Raiz;

            while (nodo.Proximo != null)
            {
                nodo = nodo.Proximo;
            }
            return nodo;
        }
        public void Concatena(ListaEncadeada outraLista)
        {
            if (_Raiz == null)
            {
                _Raiz = outraLista._Raiz;
            }
            else
            {
                Nodo last = ultimoNodo();

                if (last != null)
                {
                    last.Proximo = outraLista._Raiz;
                }
            }
        }
    }
}
