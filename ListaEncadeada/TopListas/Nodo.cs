using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TopListas
{
    public class Nodo
    {
        public int Conteudo { get; set; }
        public Nodo Proximo { get; set; }
        public Nodo(int conteudo)
        {
            Conteudo = conteudo;
        }
    }
}
