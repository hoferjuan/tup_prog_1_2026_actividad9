using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static NumericService servicio = new NumericService();

        static public void MostrarPantallaMenu()
        {
            Console.WriteLine("1- Solicitar un número\r\n2- Informar acumulado\r\n3- Informar cantidad de acumulados\r\n4- Calcular e informar el promedio\r\n5-Mostrar Desde Hasta\r\n6-SALIR");
        }
        static public void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese Número");
        }
        static public void MostrarPantallaAcumulado()
        {
            Console.WriteLine($"El acumulado es: {servicio.ObtenerAcumulado()}");
        }
        static public void MostrarPantallaCantidadIngresados()
        {
            Console.WriteLine($"La Cantidad de ingresados es: {servicio.Cantidad}");
        }
        static public void MostrarPantallaPromedio()
        {
            Console.WriteLine($"El Promedio es: {servicio.CalcularPromedio()}");
        }
        static public void MostrarPantallaNumerosDesdeHastaIndice()
        {
            Console.WriteLine("Ingrese indice de inicio:");
            int indiceDesde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese indice final:");
            int indiceHasta = Convert.ToInt32(Console.ReadLine());
            servicio.ObtenerNumeros(indiceDesde, indiceHasta);
        }

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarPantallaMenu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        int numero = Convert.ToInt32(Console.ReadLine());
                        servicio.RegistrarNumero(numero);
                        break;
                    case 2:
                        MostrarPantallaAcumulado();
                        break;
                    case 3:
                        MostrarPantallaCantidadIngresados();
                        break;
                    case 4:
                        MostrarPantallaPromedio();
                        break;
                    case 5:
                        MostrarPantallaNumerosDesdeHastaIndice();
                        break;
                }

            } while (opcion != 6);
        }
    }
}
