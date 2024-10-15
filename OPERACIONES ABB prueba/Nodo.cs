using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES_ABB_prueba
{
    internal class Nodo
    {

        public int dato;
        public Nodo izq;
        public Nodo der;
        public Nodo(int dato) 
        {
            izq = null;
            this.dato = dato;
            der = null;
        }
    }
}
