using System;

namespace Practica12
{
    class Nodo
    {
        private Nodo siguiente;
        private Nodo anterior;
        private Nodo hijoDerecho;
        private Nodo hijoIzquierdo;
        private char valor;

        public Nodo(char valor)
        {
            this.valor = valor;
        }

        public Nodo Siguiente 
        { 
            get { return siguiente; } 
            set { siguiente = value; } 
        }
        public Nodo Anterior 
        { 
            get { return anterior; } 
            set { anterior = value; } 
        }
        public Nodo HijoDerecho
        { 
            get { return hijoDerecho; } 
            set { hijoDerecho = value; } 
        }
        public Nodo HijoIzquierdo 
        { 
            get { return hijoIzquierdo; } 
            set { hijoIzquierdo = value; } 
        }
        public char Valor 
        { 
            get { return valor; } 
            set { this.valor = value; } 
        }
    }
}