using System;

namespace Practica12
{
    class ExpresionesAritmeticas
    {
        private Nodo ArbolBinario;
        private Nodo UltimoNodo;

        private string expresion;
        private string postorden;
        private string preorden;

        public String Expresion
        {
            get { return expresion; }
            set { expresion = value; }
        }

        public String Postorden
        {
            get { return postorden; }
            set { postorden = value; }
        }

        public String Preorden
        {
            get { return preorden; }
            set { preorden = value; }
        }

        //Genera el arbol binario a partir de la expresion
        public void generarArbolBinario()
        {
            ArbolBinario = null;
            preorden = "";
            postorden = "";

            //procesar primer jerarquia de operadores * y /
            for(int e = 0; e < expresion.Length; e++)
            {
                if(expresion[e] == '/' || expresion[e] == '*')
                {
                    Nodo operacion = new Nodo(expresion[e]);
                    operacion.HijoIzquierdo = SacarFinal();
                    operacion.HijoDerecho = new Nodo(expresion[e + 1]);
                    AgregarFinal(operacion);
                    e++;
                }
                else
                {
                    AgregarFinal(new Nodo(expresion[e]));
                }   
            }

            Nodo Nivel1 = ArbolBinario;
            ArbolBinario = null;

            //procesar segunda jerarquia de operadores + y -
            while(Nivel1.Siguiente != null)
            {
                if(Nivel1.Valor == '+' || Nivel1.Valor == '-')
                {
                    Nodo operacion = new Nodo(Nivel1.Valor);
                    operacion.HijoIzquierdo = SacarFinal();
                    operacion.HijoDerecho = Nivel1.Siguiente;
                    AgregarFinal(operacion);
                    Nivel1 = Nivel1.Siguiente;
                }
                else
                {
                    AgregarFinal(Nivel1);
                }
                if(Nivel1.Siguiente != null)
                    Nivel1 = Nivel1.Siguiente;
            }

            Preorder(UltimoNodo);
            Postorder(UltimoNodo);
            
        }

        private void Postorder(Nodo nodo)
        {
            if(nodo != null)
            {
                Postorder(nodo.HijoIzquierdo);
                Postorder(nodo.HijoDerecho);
                postorden += nodo.Valor + " ";
            }
        }

        private void Preorder(Nodo nodo)
        {
            if(nodo != null)
            {
                preorden += nodo.Valor + " ";
                Preorder(nodo.HijoIzquierdo);
                Preorder(nodo.HijoDerecho);
            }
        }

        private Nodo SacarFinal()
        {
            if(UltimoNodo != null)
            {
                Nodo tmp = UltimoNodo;

                if(UltimoNodo.Anterior == null)
                {
                    ArbolBinario = null;
                    UltimoNodo = ArbolBinario;
                }
                else
                {
                    UltimoNodo = UltimoNodo.Anterior;
                    UltimoNodo.Siguiente = null;
                }
                return tmp;
            }

            return null;
        }

        private void AgregarFinal(Nodo nuevoNodo)
        {
            if(ArbolBinario != null)
            {
                nuevoNodo.Anterior = UltimoNodo;
                UltimoNodo.Siguiente = nuevoNodo;
                UltimoNodo = UltimoNodo.Siguiente;
            }
            else
            {
                ArbolBinario = nuevoNodo;
                UltimoNodo = ArbolBinario;
            }
        }
    }
}
