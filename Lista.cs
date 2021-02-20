using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_NODO
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;

        }
        public void buscarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            Console.WriteLine("Ingrese el dato del nodo a buscar:");
            int nodoBuscar = int.Parse(Console.ReadLine());
            while (actual !=null && encontrado == false)
            {
                if (actual.Dato == nodoBuscar)
                {
                    Console.WriteLine("\n Nodo con el dato ({0}) encontrado \n" + actual.Dato);
                    encontrado = true;
                }
               
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine("\n Nodo no encontrado\n");
            }

        }
        
    }
}
