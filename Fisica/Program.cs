using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula magnitud fisicas");
            Console.WriteLine("1-Velocidad 2-Tiempo 3-Distancia");
            int opcion = int.Parse(Console.ReadLine());
            double tiempo, distancia, velocidad;

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese la distancia");
                distancia = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo");
                tiempo = double.Parse(Console.ReadLine());

                velocidad = distancia / tiempo;
                Console.WriteLine("La velocidad es " + velocidad);

            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese la distancia");
                distancia = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la velocidad");
                velocidad = double.Parse(Console.ReadLine());

                tiempo = distancia / velocidad;
                Console.WriteLine("El tiempo es " + tiempo);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese la velocidad");
                velocidad = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo");
                tiempo = double.Parse(Console.ReadLine());

                distancia = tiempo * velocidad;
                Console.WriteLine("La distancia es " + distancia);
            }
            else {
                Console.WriteLine("Ingrese una opcion valida");
            }
            Console.ReadLine();
        }
    }
}
