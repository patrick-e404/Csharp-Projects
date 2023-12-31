﻿using System;
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
        private int tamanho;

        public ListaEncadeada()
        {
            this._Raiz = null;
            this.tamanho = 0;
        }

        public void Exibir()
        {
            if (_Raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            Console.Write($"{_Raiz.Conteudo}/");
            Nodo nodo = _Raiz.Proximo;

            while (nodo != null)
            {
                Console.Write($"{nodo.Conteudo}/");
                nodo = nodo.Proximo;
            }
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
            tamanho++;
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
        public void RemoverDuplo()
        {
            if (_Raiz == null || _Raiz.Proximo == null)
            {
                return;
            }
            Nodo nodoAtual = _Raiz;

            while (nodoAtual != null)
            {
                Nodo nodoComparacao = nodoAtual;

                while (nodoComparacao.Proximo != null)
                {
                    if (nodoComparacao.Proximo.Conteudo == nodoAtual.Conteudo)
                    {
                        nodoComparacao.Proximo = nodoComparacao.Proximo.Proximo;
                    }
                    else
                    {
                        nodoComparacao = nodoComparacao.Proximo;
                    }
                }
                nodoAtual = nodoAtual.Proximo;
            }
        }
        public ListaEncadeada Intersecao(ListaEncadeada outraLista)
        {
            ListaEncadeada resultado = new ListaEncadeada();

            Nodo nodoLista1 = _Raiz;

            while (nodoLista1 != null)
            {
                Nodo nodoLista2 = outraLista._Raiz;

                while (nodoLista2 != null)
                {
                    if (nodoLista1.Conteudo == nodoLista2.Conteudo)
                    {
                        resultado.Inserir(nodoLista1.Conteudo);
                        break;
                    }
                    nodoLista2 = nodoLista2.Proximo;
                }
                nodoLista1 = nodoLista1.Proximo;
            }
            return resultado;
        }
        public void Ordenar()
        {
            if (_Raiz == null || _Raiz.Proximo == null)
            {
                return;
            }
            bool troca;

            do
            {
                troca = false;
                Nodo nodoAtual = _Raiz;
                Nodo nodoAnterior = null;

                while (nodoAtual.Proximo != null)
                {
                    if (nodoAtual.Conteudo > nodoAtual.Proximo.Conteudo)
                    {
                        Nodo temp = nodoAtual.Proximo;
                        nodoAtual.Proximo = temp.Proximo;
                        temp.Proximo = nodoAtual;

                        if (nodoAnterior != null)
                        {
                            nodoAnterior.Proximo = temp;
                        }
                        else
                        {
                            _Raiz = temp;
                        }
                        nodoAnterior = temp;
                        troca = true;
                    }
                    else
                    {
                        nodoAnterior = nodoAtual;
                        nodoAtual = nodoAtual.Proximo;
                    }
                }
            }
            while (troca);
        }
        public ListaEncadeada[] Dividir()
        {
            if (this.tamanho <= 1)
            {
                return new ListaEncadeada[] { this };
            }
            int metade = this.tamanho / 2;
            ListaEncadeada lista1 = new ListaEncadeada();
            ListaEncadeada lista2 = new ListaEncadeada();

            Nodo nodoAtual = this._Raiz;
            int i = 0;

            while (i < metade)
            {
                lista1.Inserir(nodoAtual.Conteudo);
                nodoAtual = nodoAtual.Proximo;
                i++;
            }
            lista2._Raiz = nodoAtual;
            return new ListaEncadeada[] { lista1, lista2 };
        }
    }
}