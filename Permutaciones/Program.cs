using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el numero de elementos:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los elementos separados por un espacio");
            int[] set = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("Permutaciones con repeticion (y/n)?");
            string withRepetition = Console.ReadLine();

            if (withRepetition.ToLower() == "y")
            {
                Console.WriteLine("Introduzca el tamaño de la permutacion");
                int r = int.Parse(Console.ReadLine());
                int permutations = (int)Math.Pow(n, r);
                Console.WriteLine("El numero de permutacion con repeticion es: " + permutations);
            }
            else
            {
                int permutations = Factorial(n);
                Console.WriteLine("El numero de permutacion sin repeticion es: " + permutations);
            }
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
