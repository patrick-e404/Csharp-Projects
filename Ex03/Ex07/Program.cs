using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    public class Program
    {
        Produto produto = new Produto();
        public Program() 
        { 
            Produto produto1 = new Produto("Camiseta", 20, 50);
            produto1.DadosProdutos();
            produto1.AdicinonarEstoque(10);
            produto1.RemoverEstoque(5);
        }

        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
