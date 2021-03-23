using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_ELEMENTO_BINARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ABB arbol = new ABB();// declaramos
            arbol.insertar(80);
            arbol.insertar(70);
            arbol.insertar(88);
            arbol.insertar(20);
            arbol.insertar(42);
            arbol.insertar(60);
            arbol.insertar(9);
            arbol.insertar(10);
            arbol.insertar(10);

            //imprimir en consola en orden
            Console.WriteLine("insertar enorden");
            arbol.enOrden(arbol.raiz);
            Console.WriteLine("");

            // imprimir en consola en portOrden
            Console.WriteLine("Recorrido portorden");
            arbol.portOrden(arbol.raiz);
            Console.WriteLine("");

            //imprimir en consola en preorden

            Console.WriteLine("Recorrido preorden");
            arbol.PreOrden(arbol.raiz);
            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
