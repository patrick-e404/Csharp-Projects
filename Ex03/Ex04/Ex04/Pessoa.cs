using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string endereco;

        public Pessoa()
        {
            nome = string.Empty;
            idade = 0;
            endereco = string.Empty;
        }
        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }
        public string Nome
        {
            get { return nome; } 
            set { Nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public void MostrarDestalhes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Endereço: {endereco}");
        }
    }
}
