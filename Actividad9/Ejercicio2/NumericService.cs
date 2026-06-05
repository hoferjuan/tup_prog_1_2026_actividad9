using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class NumericService
    {
        public int acumulado = 0, cantidad = 0;

        public void RegistrarNumero(int numero)
        {
            acumulado += numero;
            cantidad++;
        }
        public int ObtenerAcumulado()
        {
            return acumulado;
        }
        public double CalcularPromedio()
        {
            if (cantidad > 0)
            {
                double promedio = (double)acumulado / cantidad;
                return promedio;
            }
            else { return 0; }
        }
    }
}
