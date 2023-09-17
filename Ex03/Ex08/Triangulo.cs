using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    public class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo()
        {
            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public Double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }
        public Double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }
        public bool VerificarValidade()
        {
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                Console.WriteLine("É um triangulo.");
                return true;
            }
            else
            {
                Console.WriteLine("Não é triangulo.");
                return false;
            }
        }
    }
}