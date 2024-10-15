using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES_ABB_prueba
{
    internal class Arbol
    {
        int dato = 0;
        public Nodo raiz;
        public Arbol() 
        {
            raiz = null;
        }
        public void Insertar() 
        {
            Nodo nuevo= new Nodo(dato);
            Console.WriteLine("Ingrese Numero de hijos: ");
            dato= int.Parse(Console.ReadLine());

            nuevo.dato = dato;
            if(raiz==null)
            {
                raiz = nuevo;
            }
            else
            {
                Nodo ante=null; Nodo nreco = raiz;

                while(nreco!=null) 
                {
                    ante= nreco;
                    if (nuevo.dato < nreco.dato) nreco = nreco.izq;
                    else nreco = nreco.der;
                }
                if (nuevo.dato < ante.dato) ante.izq = nuevo;
                else ante.der=nuevo;
            }

        }

        private void InOrden(Nodo nreco) 
        {
            if(nreco!=null)
            {
                InOrden(nreco.izq);
                Console.Write(nreco.dato+ " ");
                InOrden(nreco.der);
            }
        }
        public void InOrden() 
        {
            InOrden(raiz);
            Console.WriteLine();
        }
        private void PosOrden(Nodo nreco)
        {
            if (nreco != null)
            {
                InOrden(nreco.izq);
                InOrden(nreco.der);
                Console.Write(nreco.dato + " ");

            }
        }
        public void PosOrden()
        {
            InOrden(raiz);
            Console.WriteLine();
        }
        public Nodo Buscar(int dato) 
        {
            Nodo nreco = raiz;
            while(nreco.dato!=dato) 
            {
                if (dato < nreco.dato) nreco = nreco.izq;
                else nreco = nreco.der;
                if (nreco == null) return null;
            }
            return nreco;
        }
        public void Buscar()
        {
            Console.WriteLine("Ingrese numero a buscar: ");
            int dato= int.Parse(Console.ReadLine());
            if (Buscar(dato) == null) Console.WriteLine("numero no encontrado");
            else Console.WriteLine("Numero encontrado");
        }
        public bool Eliminar() 
        {
            Console.WriteLine("Ingrese numero a eliminar: ");
            int dato= int.Parse(Console.ReadLine()) ;
            Nodo nreco = raiz;
            Nodo npadre = raiz;
            bool hijoizq = true;

            while (nreco.dato!=dato) 
            {
                npadre = nreco;
                if (dato < nreco.dato) 
                { 
                hijoizq = true; nreco= nreco.izq;
                }
                else { 
                       hijoizq = false; nreco= nreco.der;
                }
            }
            if(nreco.izq==null &&  nreco.der==null) 
            {
                if (nreco == raiz) raiz = null;
                else if (hijoizq) npadre.izq = null;
                else npadre.der= null;

            }
            else if(nreco.der==null) 
            {
                if (nreco == raiz) raiz = nreco.izq;
                else if (hijoizq) npadre.izq = nreco.izq;
                else npadre.der = nreco.izq;
            }
            else if (nreco.izq==null) 
            {
                if (nreco == raiz) raiz = nreco.der;
                else if (hijoizq) npadre.izq = nreco.der;
                else npadre.der= nreco.izq;
            }
            else 
            {
                Nodo nreemp=ObtenerReemp(nreco);
                if (nreco == raiz) raiz = nreemp;
                else if (hijoizq) npadre.izq = nreemp;
                else npadre.der = nreemp;
            }
            return true;
        }
        public Nodo ObtenerReemp(Nodo nodoreemp) 
        {
            Nodo nrpadre = nodoreemp;
            Nodo nreemp = nodoreemp;
            Nodo nreco=nodoreemp.der;

            while(nreco != null) 
            {
                nrpadre=nreemp;
                nreemp = nreco;
                nreco = nreco.izq;
            }
            if(nreemp!=nodoreemp.der) 
            {
                nrpadre.izq = nreemp.der;
                nreemp.der = nodoreemp.der;
            }
            Console.WriteLine("La edad que reemplazara al nodo eliminado es: " + nreemp.dato);
            return nreemp;
        }

    }
}
