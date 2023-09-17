using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private int velocidadeAtual;

        public Carro() 
        { 
            marca = string.Empty;
            modelo = string.Empty;
            velocidadeAtual = 0;
        }
        public Carro(string marca, string modelo, int velocidadeAtual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidadeAtual = velocidadeAtual;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        } 
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            set { velocidadeAtual = value; }
        }
        public void Acelerar(int valor)
        {
            velocidadeAtual += valor;
            Console.WriteLine($"Você está acelarando e sua velocidade é: {velocidadeAtual} km/h");
        }
        public void Desacelerar(int valor)
        {
            velocidadeAtual -= valor;
            Console.WriteLine($"Você está desacelerando e sua velocidade é: {velocidadeAtual} km/h");
        }
        public void ExibirDadosCarro()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Velocidade: {velocidadeAtual}");
        }
    }
}
