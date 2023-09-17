using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Program
    {
        Pessoa pessoa1;
        public Program()
        {
            Pessoa pessoa1 = new Pessoa("Maria", 30, "Rua ABC, 123");
            pessoa1.MostrarDestalhes();
        } 
            
    static void Main(string[] args)
    {
        Program start = new Program();
        Console.ReadKey();
    }
}
}
