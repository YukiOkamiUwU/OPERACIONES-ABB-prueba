using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES_ABB_prueba
{
    internal class Program
    {
        public static Arbol arbol= new Arbol();
        static void Main(string[] args)
        {

            int op = 0;
            do
            {
                Console.WriteLine("BIENVENIDO AL PROGRAMA");
                Console.WriteLine("1.INSERTAR");
                Console.WriteLine("2.InOrden");
                Console.WriteLine("3. PostOrden");
                Console.WriteLine("4.Buscar");
                Console.WriteLine("5.Eliminar");
                Console.WriteLine("6. SALIR");
                Console.WriteLine("Ingrese opcion: ");
                op= int.Parse(Console.ReadLine());

                switch(op) 
                {
                    case 1:InsertarNumero();Console.ReadKey();Console.Clear(); break;
                    case 2: inorden(); Console.ReadKey(); Console.Clear(); break;
                    case 3: posorden(); Console.ReadKey(); Console.Clear(); break;
                    case 4:buscar(); Console.ReadKey(); Console.Clear(); break;
                    case 5: Eliminar(); Console.ReadKey(); Console.Clear(); break;
                    case 6: Console.WriteLine("SALISTE");  Console.ReadKey(); break; 
                    default: break;
                }

            } while (op !=6);
            Console.ReadKey();
        }
        static void InsertarNumero() 
        {
            arbol.Insertar();
        }
        static void inorden()
        {
            arbol.InOrden();
        }
        static void posorden()
        {
            arbol.PosOrden();
        }
        static void buscar()
        {
            arbol.Buscar();
        }
        static void Eliminar()
        {
            arbol.Eliminar();
        }
    }
}
