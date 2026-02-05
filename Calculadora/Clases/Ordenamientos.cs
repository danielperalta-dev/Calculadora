using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculadora.Clases
{
    internal class Ordenamientos
    {
        int[] arreglo;
        public Ordenamientos()
        { }

            public int[] Burbuja(int[] arreglo)
            {
            try
            {
                this.arreglo = arreglo;
                int aux;
                for(int i = 0; i < arreglo.Length; i++)
                {
                    for(int j = 0; j < arreglo.Length - 1; j++)
                    {
                        if(arreglo[j] > arreglo[j + 1])
                        {
                            aux = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = aux;
                        }
                    }
                }
                return arreglo;
            }
            catch (Exception ex)
            {
                throw;
                return null;
            }
        }
    }
}
