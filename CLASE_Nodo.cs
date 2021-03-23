using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_ELEMENTO_BINARIO
{
    class Nodo
    {
        public Nodo hi;
        public Nodo hd;
        public int valor;

        public Nodo() // Agregamos un constructor
        {
            hi = null; // declaramos nulo tanto a su hijo izquierdo 
            hd = null; //como a la derecha
            valor = 0; 
        } 
    }
}
