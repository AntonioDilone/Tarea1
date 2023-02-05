using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Trigonometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula funciones trigonometricas");
            Console.WriteLine("1-seno 2-coseno 3-secante 4-cosecante 5-tangente 6-cotangente");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Angulo a calcular");
            double numero = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                double resultado = Math.Sin(numero);
                Console.WriteLine("El seno de " + numero + " es " + resultado);
            }
            else if (opcion == 2)
            {
                double resultado = Math.Acos(numero);
                Console.WriteLine("El coseno de " + numero + " es " + resultado);
            }
            else if (opcion == 3)
            {
                double resultado = 1 / Math.Acos(numero);
                Console.WriteLine("La secante de " + numero + " es " + resultado);
            }
            else if (opcion == 4)
            {
                double resultado = 1 / Math.Sin(numero);
                Console.WriteLine("La cosecante de " + numero + " es " + resultado);
            }
            else if (opcion == 5)
            {
                double resultado = Math.Atan(numero);
                Console.WriteLine("La tangente de " + numero + " es " + resultado);
            }
            else if (opcion == 6)
            {
                double resultado = 1 / Math.Atan(numero);
                Console.WriteLine("La cotangente de " + numero + " es " + resultado);
            }
            else {
                Console.WriteLine("Esa no es una opcion valida");
            }
            Console.ReadLine(); 
        }
    }
}
