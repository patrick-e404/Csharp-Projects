using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidadeEmEstoque;

        public Produto()
        {
            nome = string.Empty;
            preco = 0;
            quantidadeEmEstoque = 0;
        }
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }
        public string Nome
        {
            get { return nome; } 
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int QuantidadeEmEstoque
        {
            get { return quantidadeEmEstoque; }
            set { quantidadeEmEstoque = value; }
        }
        public void AdicinonarEstoque(int valor)
        {
            quantidadeEmEstoque += valor;
            Console.WriteLine($"Quantidade em estoque após adicionar: {QuantidadeEmEstoque}");
        }
        public void RemoverEstoque(int valor)
        {
            quantidadeEmEstoque -= valor;
            Console.WriteLine($"Quantidade em estoquee após remoção: {quantidadeEmEstoque}");
        }
        public void DadosProdutos()
        {
            Console.WriteLine($"Produto; {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade inicial em estoque: {QuantidadeEmEstoque}");
        }
    }
}
