using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************BUSQUEDA***************");
            Console.WriteLine("Ingrese el tamaño del vector: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero minimo para generar los datos: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero maximo para generar los datos: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Array numeros = new Array(tam, min, max);
            numeros.generarVector();
            Console.Clear();
            

            numeros.mostrarvector();
            numeros.ordenarVector();
            Busqueda busqueda = new Busqueda();
            
            int salir =0;
            do{
           
            Console.WriteLine("Ingrese el numero a buscar: ");
            int clave = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************TIPOS DE BUSQUEDA***************");
            Console.WriteLine("1  Busqueda lineal secuencial.");
            Console.WriteLine("2 Busqueda lineal recursiva.");
            Console.WriteLine("3 Busqueda binaria Lineal.");
            Console.WriteLine("4 Busqueda binaria recursiva.");
            Console.WriteLine("5 Salir.");
            
            Console.WriteLine("Seleccione una opcion por favor: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1: int a =busqueda.busquedaLinealSec(numeros.Numeros,clave);
                    comparar(a);
                    break;
                case 2:int b = busqueda.busquedaLinealRec(numeros.Numeros, clave, numeros.Numeros.Length, 0);
                    comparar(b);
                    break;
                case 3: numeros.ordenarVector();
                    int c = busqueda.busquedaBinariaSec(numeros.Numeros,clave);
                    comparar(c);
                    break;
                case 4: numeros.ordenarVector();
                    numeros.mostrarvector();
                    int d = busqueda.busquedaBinariaRec(numeros.Numeros,clave,0,numeros.Numeros.Length);
                    comparar(d);
                    break;
                case 5: Console.WriteLine("ADIOS.");
                    salir = opcion;
                    break;
                default: Console.WriteLine("Opcion no valida.\nIngrese una opcion valida.\n");
                    break;
            }
            }while(salir !=5);
            Console.ReadLine();


        }
        public static void comparar(int a)
        {
            if (a ==1)
            {
                Console.WriteLine("\n\nEl numero se encontro en el vector.\n\n");
            }
            else
            {
                Console.WriteLine("\nEl numero no se encontro en el vector.\n\n");
            }
        }
    }
}
