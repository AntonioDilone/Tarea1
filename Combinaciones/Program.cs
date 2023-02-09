using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ingresa el tamaño de la población: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el tamaño de la muestra: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Quieres calcular las combinaciones con repetición? (s/n)");
                string opcion = Console.ReadLine();
                double resultado;
                if (opcion.ToLower() == "s")
                {
                    resultado = CombinacionesConRepeticion(n, k);
                }
                else
                {
                    resultado = CombinacionesSinRepeticion(n, k);
                }
                Console.WriteLine("El resultado es: " + resultado);
                Console.ReadLine();
            }

            double CombinacionesConRepeticion(int n, int k)
            {
                return Factorial(n + k - 1) / (Factorial(k) * Factorial(n - 1));
            }

            double CombinacionesSinRepeticion(int n, int k)
            {
                return Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

            double Factorial(int num)
            {
                double resultado = 1;
                for (int i = 1; i <= num; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }

    }
}
