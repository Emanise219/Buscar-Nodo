using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCAR_ELEMENTO_BINARIO
{
    class ABB
    {
        public Nodo raiz; // esta clase tendra un unico atributo
        public ABB() // Constructor
        {
            raiz = null;// iniciamos la raiz como nulo

        }
        public void insertar(int valor)// el metodo insertar recibira un valor de tipo int
        {
            if (raiz == null) // preguntamos si la raiz es nulo
            {
                raiz = new Nodo();  // creamos un  nuevo nodo
                raiz.valor = valor; // le agregamos un valor
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.hd = null;
                nuevo.hi = null; // en el caso de que la raiz no sea nula
                Nodo anterior = null, recorrer; // creamos un nodo anterior y un nodo recorrer
                recorrer = raiz;
                while (recorrer != null) // para saber la posicion
                {
                    anterior = recorrer; // agregamos un nuevo valor
                    if (valor < recorrer.valor)
                    {
                        recorrer = recorrer.hd;
                    }
                    else
                    {
                        recorrer = recorrer.hi;
                    }
                }
                if (valor < anterior.valor)
                {
                    anterior.hd = nuevo;
                }
                else
                {
                    anterior.hi = nuevo;
                }
            }
        }
        // Metodo mostrar ABB en PreOrden
        public void PreOrden(Nodo raiz) // para recorrer el arbol como izquierda y derecha
        {
            Console.WriteLine(raiz.valor); 
            if (raiz.hi != null) //y madandamos el metodo preorden otra vez
                PreOrden(raiz.hd);
            if( raiz != null)
                PreOrden(raiz.hd);
           
        }
        // metodo mostrar ABB EN Orden
public void enOrden(Nodo raiz)
        {
            if (raiz.hi != null)
                enOrden(raiz.hi);
            Console.WriteLine(raiz.valor);
            if (raiz.hd != null) // si la raiz derecha esta vacia
                enOrden(raiz); // ejecutamos la orden otra vez

        }
        // metodo de mostar ABB en portOrden
        public void portOrden(Nodo raiz) 
        {
            if (raiz.hi != null) //si este recorrigo empieza a correr el arbol hacia izquierda
                portOrden(raiz.hi);
            if (raiz.hd != null)
                portOrden(raiz.hd);

            Console.WriteLine(raiz.valor);
        }
            
    }
}
