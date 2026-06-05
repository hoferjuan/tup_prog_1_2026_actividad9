using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        //Instanciar
        static NumericService servicio = new NumericService();

        static void MostrarPantallaMenu()
        {
            Console.WriteLine("1- Solicitar un número\r\n2- Informar acumulado\r\n3- Informar cantidad de acumulados\r\n4- Calcular e informar el promedio\r\n5- Salir\r\n");
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese Número");
        }
        static void MostrarPantallaAcumulado()
        {
            Console.WriteLine($"El acumulado es {servicio.ObtenerAcumulado()}");
        }
        static void MostrarPantallaCantidadIngresados()
        {
            Console.WriteLine($"La cantidad de ingresados es {servicio.cantidad}");
        }
        static void MostrarPantallaPromedio()
        {
            Console.WriteLine($"El promedio es: {servicio.CalcularPromedio()}");
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
                }

            } while (opcion != 5);


        }
    }
}
