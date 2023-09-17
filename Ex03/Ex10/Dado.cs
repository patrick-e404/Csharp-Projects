using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    public class Dado
    {
        private Random random;
        public Dado() 
        { 
            random = new Random();
        }
        public int RolarDado()
        {
            int resultado = random.Next(1, 7);
            {
                return  resultado;
            }
        }
    }
}
