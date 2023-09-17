using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    public class Agenda
    {
        private string[] contatos;
        private string[] telefones;
        private int espacoAgenda;

        public Agenda()
        {
            contatos = new string[5];
            telefones = new string[5];
            espacoAgenda = 0;
        }
        public void AdicionarContato(string nome, string telefone)
        {
            if (espacoAgenda < 5)
            {
                contatos[espacoAgenda] = nome;
                telefones[espacoAgenda] = telefone;
                espacoAgenda++;
            }
            else
            {
                Console.WriteLine("Agenda está cheia.");
            }
        }
        public void ListarContatos()
        {
            Console.WriteLine("Agenda:");
            for (int i = 0; i < espacoAgenda; i++)
            {
                Console.WriteLine($"Nome:  {contatos[i]}, telefone: {telefones[i]}");
            }
        } 
    }
}
