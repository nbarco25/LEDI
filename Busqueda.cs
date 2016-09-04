using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Busqueda
    {
        //Constructor por defecto
        public Busqueda()
        {

        }
        //Metodos
        public int busquedaLinealSec(int[] numeros, int n)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (n == numeros[i])
                {
                    return 1;
                }
            }
            return -1;
        }

        public int busquedaLinealRec(int[] A, int clave, int n, int i)
        {
            if (i == n)
            {
                return -1;
            }
            else if (A[i] == clave)
            {
                return 1;
            }
            else
            {
                return busquedaLinealRec(A, clave, n, i + 1);

            }
        }

        public int busquedaBinariaSec(int[] A,int clave)
        {
           int medio,inf=0,sup=A.Length-1;
           while (inf <= sup)
           {
               medio = (inf + sup) / 2;
               if (A[medio] == clave) 
               {
                   return 1;
               }
               else if (clave < A[medio])
               {
                   sup = medio - 1;
               }
               else
               {
                   inf = medio + 1;
               }
           }
           return -1;

  
        }

        public int busquedaBinariaRec(int[]A,int clave,int inf,int sup)
        {
            int a=0;
            if (inf < sup)
            {
                int medio = (inf + sup) / 2;
                if (clave > A[medio])
                {
                    a = busquedaBinariaRec(A, clave, medio + 1, sup);
                }
                else if(clave < A[medio])
                {
                    a = busquedaBinariaRec(A,clave,inf,medio-1);
                }
                else
                {
                    return 1;
                }
            }
            if (a == 1)
            {
                return a;
            }
            return -1;
        }





    }
}
