using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_NODO
{
    class Nodo
    {
        private int dato;
        private Nodo siguente;
        private Nodo atras;


        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get {  return siguente; }
            set { siguente = value; }

        }
        public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
            
        
    }
}
