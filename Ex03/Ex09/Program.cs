using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    public class Program
    {
        Agenda minhaAgenda;
        public Program() 
        { 
            Agenda minhaAgenda = new Agenda();
            minhaAgenda.AdicionarContato("Maria", "123-456-7890");
            minhaAgenda.AdicionarContato("João", "9877-654-3210");
            minhaAgenda.ListarContatos();
        }

        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();
        }
    }
}
