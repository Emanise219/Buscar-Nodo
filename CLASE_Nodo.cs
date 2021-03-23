using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_ELEMENTO_BINARIO
{
    class Nodo
    {
        public Nodo hi; // nodo izquierdo
        public Nodo hd; // nodo derecho
        public  int valor; // valor entero

        public Nodo()
        {
            hi = null;
            hd = null;
            valor = 0;
        }
    }
}
