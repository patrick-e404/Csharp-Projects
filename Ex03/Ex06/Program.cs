using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    public class Program
    {
        Aluno aluno;
        public Program()
        {
            Aluno aluno1 = new Aluno("João","12345",8.0);
            aluno1.ExibirDados();
            bool aprovado = aluno1.VerificarAprovacao();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
