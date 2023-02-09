using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que resuelve ecuaciones de primer grado");
            int x;
            Console.WriteLine("Ingrese el valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b: ");
            int b = int.Parse(Console.ReadLine());

            if (a != 0) {
                x = (-1*b) / a;
                Console.WriteLine("Esta es la solucion" + x);
            } else if (b != 0) {
                Console.WriteLine("Solucion imposible");
            }
            else
            {
                Console.WriteLine("Solucion indeterminada");
            }
            Console.ReadLine();
        }
    }
}
