using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        //Variables
        public int acumulado = 0;
        public int cantidad = 0;

        //Métodos
        public void RegistrarNumero(int numero)
        {
            cantidad++;
            acumulado += numero;
        }
        public int ObtenerAcumulado()
        {
            return acumulado;
        }
        public double CacularPromedio()
        {
            if (cantidad > 0)
            {
                double promedio = (double)acumulado / cantidad;
                return promedio;
            }
            else { return 0; }
        }

        public void MostrarPantallaMenu()
        {
            
            Console.WriteLine("1- Solicitar un número\r\n2- Informar acumulado\r\n3- Informar cantidad de acumulados\r\n4- Calcular e informar el promedio\r\n5- Salir\r\n");
        }
        public void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese el número");

        }
        public void MostrarPantallaAcumulado()
        {
            Console.WriteLine($"El acumulado es {acumulado}");
        }
        public void MostrarPantallaCantidadIngresados()
        {
            Console.WriteLine($"La cantidad de ingresados es {cantidad}");
        }
        public void MostrarPantallaPromedio()
        {
            Console.WriteLine($"El promedio es : {CacularPromedio()}");
        }



        static void Main(string[] args)
        {
            Program miProgram = new Program();
            int opcion;
            do
            {
                
                miProgram.MostrarPantallaMenu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        miProgram.MostrarPantallaSolicitarNumero();
                        int numero = Convert.ToInt32(Console.ReadLine());
                        miProgram.RegistrarNumero(numero);
                        break;
                    case 2:
                        miProgram.MostrarPantallaAcumulado();
                        break;
                    case 3:
                        miProgram.MostrarPantallaCantidadIngresados();
                        break;
                    case 4:
                        miProgram.MostrarPantallaPromedio();
                        break;

                }
            } while (opcion != 5);

        }
    }
}
