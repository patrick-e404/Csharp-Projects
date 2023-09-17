using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    public class Program
    {
        Carro meuCarro;
        public Program() 
        {
            meuCarro = new Carro("Ford","Ka", 60);
            meuCarro.ExibirDadosCarro();
            meuCarro.Acelerar(20);
            meuCarro.Desacelerar(10);
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
