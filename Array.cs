using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Array
    {
        //atriubutos
        private int tam;
        private int min;
        private int max;
        private int[] numeros;
        //Constructor
        public Array(int tam,int min,int max)
        {
            this.tam = tam;
            this.min = min;
            this.max = max;
            numeros = new int[this.tam];
        }
        //Getter and setter
        public int[] Numeros
        {
            get
            {
                return numeros;
            }

            set
            {
                numeros = value;
            }
        }

        public int Tam
        {
            get
            {
                return tam;
            }

            set
            {
                tam = value;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }

        //Metodos
        public void generarVector()
        {
            Random rand = new Random();
            int aleatorio;
            for (int i = 0; i < numeros.Length; i++)
            {
                aleatorio = rand.Next(min, max);
                numeros[i] = aleatorio;
            }  
        }

        public void ordenarVector()
        {
            int aux;
            for (int a = 1; a < numeros.Length; a++)
                for (int b = numeros.Length - 1; b >= a; b--)
                {
                    if (numeros[b - 1] > numeros[b])
                    {
                        aux = numeros[b - 1];
                        numeros[b - 1] = numeros[b];
                        numeros[b] = aux;
                    }
                }
            
        }

        public void mostrarvector()
        {
            Console.WriteLine("*******VECTOR*******");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+"|");
            }
            Console.WriteLine();
        }
    }
}
