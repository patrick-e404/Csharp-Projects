using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    public class Aluno
    {
        private string name;
        private string matricula;
        private double nota;

        public Aluno()
        {
            name = string.Empty;
            matricula = string.Empty;
            nota = 0.0;
        }
        public Aluno(string name,string matricula,double nota)
        {
            this.name = name;
            this.matricula = matricula;
            this.nota = nota;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public bool VerificarAprovacao()
        {
            if (nota >= 6)
            {
                Console.WriteLine("Aluno foi aprovado!");
                return true;
            }
            else
            {
                Console.WriteLine("Aluno foi reprovado!");
                return false;
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {name}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Nota: {nota}");
        }
    }
}
