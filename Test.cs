using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledi_3
{
    class Test
    {
        static void Main(string[] args)
        {
            #region instancias
            Array v1 = new Array();
            Busqueda b = new Busqueda();
            #endregion

            Console.Write("Ingrese el valor minimo del vector a generar");
            v1.Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor maximo del vecror a generar");
            v1.Max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tamaño del vector");
            v1.Tamaño = Convert.ToInt32(Console.ReadLine());
            v1.generarAleatorios();
            v1.imprimirVector();
            v1.ordenarVector();
            v1.imprimirVector();

            Console.ReadKey();
        }
    }
}
