using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    public class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo()
        {
            largura = 0;
            altura = 0;
        }
        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        public double Altura
        {
            get { return altura; }
            set {  altura = value; }
        }
        public double CalcularArea()
        {
            double area = largura * altura;
            Console.WriteLine($"A area é: {area}m².");

            return area;
        }
    }
}
