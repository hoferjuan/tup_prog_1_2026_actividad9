using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class NumericService
    {
        public int[] Numeros = new int[100];
        public int Cantidad = 0;

        public void RegistrarNumero(int numero)
        {
            Numeros[Cantidad] = numero;
            Cantidad++;
        }
        public int ObtenerAcumulado()
        {
            int acum = 0;
            for (int i = 0; i < Cantidad; i++)
            {
                acum += Numeros[i];

            }
            return acum;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;

            if (Cantidad > 0)
            {
                promedio = (double)ObtenerAcumulado() / Cantidad;
            }
            return promedio;

        }
        public void ObtenerNumeros(int indiceDesde, int indiceHasta)
        {
            for (int i = indiceDesde; i <= indiceHasta; i++)
            {
                Console.WriteLine($" Posición {i} :  {Numeros[i]}");
            }
        }

    }
}
