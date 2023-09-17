using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    public class Program
    {
        Dado meuDado;
        public Program()
        {
            Dado meuDado = new Dado();
            int resultado = meuDado.RolarDado();
            Console.WriteLine("Valor no Dado:");
            Console.WriteLine(resultado);
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
