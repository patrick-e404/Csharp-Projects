using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    public class Program
    {
        Retangulo meuRetorno;
        public Program()
        {
            meuRetorno = new Retangulo(5.0, 3.0);
            double area = meuRetorno.CalcularArea();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
