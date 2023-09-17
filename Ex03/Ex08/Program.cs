using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    public class Program
    {
        Triangulo Triangulo;
        public Program() 
        {
            Triangulo meuTriangulo = new Triangulo(3.0,4.0,5.0);
            bool valido = meuTriangulo.VerificarValidade();
        }

        static void Main(string[] args)
        {
            Program stat = new Program();
            Console.ReadKey();
        }
    }
}
