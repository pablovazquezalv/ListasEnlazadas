using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class Nodo
    {
        public string valor;
        public Nodo siguiente;
        public Nodo anterior;

        public Nodo(string valor)
        {
            this.valor = valor;
            siguiente = null;
            anterior = null;
        }
    }
}
