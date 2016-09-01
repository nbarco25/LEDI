using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledi_3
{
    class Array
    {
        //incializa, ordena, y muestra el vector
        #region atributos
        private int[] numeros;
        private int numElementos;
        private int min;
        private int max;
        private int tamaño;
        #endregion
        
        #region metodos

        #region setters & getters
       

        public int NumElementos
        {
            get
            {
                return numElementos;
            }

            set
            {
                numElementos = value;
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

        public int Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
            }
        }

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

        #endregion

        #region metodosPropios

        public void generarAleatorios()
        {
            Random aleatorios = new Random();
            Numeros = new int[Tamaño];
            for (int i = 0; i < Tamaño; i++)
            {
                Numeros[i] = aleatorios.Next(Min, Max);
            }
        }
        public void ordenarVector()
        {
            for (int i = 0; i < Tamaño - 1; i++)
            {
                for (int j = i + 1; j < Tamaño; j++)
                {
                    if (Numeros[i] > Numeros[j])
                    {
                        int aux = Numeros[i];
                        Numeros[i] = Numeros[j];
                        Numeros[j] = aux;
                    }
                }
            }
        }
        public void imprimirVector()
        {
            for (int i = 0; i < Tamaño; i++)
            {
                Console.Write(Numeros[i]+"|");
            }
        }
        #endregion

        #endregion

        /*Metodo generar numeros aleatorios que inicialice el vector*/
    }
}
