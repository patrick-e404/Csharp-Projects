using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class Program
    {
        ContaBancaria contaBancaria;
        public Program()
        {
            contaBancaria = new ContaBancaria(12345, "João", 1000);
            contaBancaria.ExibirDados();
            contaBancaria.Depositar(500);
            contaBancaria.Sacar(200);
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
