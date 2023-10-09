using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herois
{
    public class Program
    {
        SuperPoder superPoder;
        public Program()
        {
            superPoder = new SuperPoder("Sentido Apurado", 1);

            superPoder.Exibir();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
