using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class ContaBancaria
    {
        private int numeroConta;
        private string nomeTitular;
        private double saldo;

        public ContaBancaria()
        {
            numeroConta = 0;
            nomeTitular = "";
            saldo = 0;
        }
        public ContaBancaria(int conta, string name, double saldo)
        {
            numeroConta = conta;
            nomeTitular = name;
            this.saldo = saldo;
        }
        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }
        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Feito deposito no valor de: {valor}");
                Console.WriteLine($"Saldo atual da conta é: {saldo}");
            }
            else
            {
                Console.WriteLine("Nenhum valor informado");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (saldo >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Feito saque no valor de: {valor}");
                    Console.WriteLine($"Saldo atual da conta é: {saldo}");
                }
                else
                {
                    Console.WriteLine("Saque não aprovado, saldo da conta é insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("Nenhum valor informado");
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Nome do titular: {NomeTitular}");
            Console.WriteLine($"Saldo atual da conta: {Saldo}");
        }
    }
}