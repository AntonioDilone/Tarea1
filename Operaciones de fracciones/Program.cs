using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_de_fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora entre fracciones");
            Console.WriteLine("1-Suma 2-Resta 3-Multiplicacion 4-Division");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numerador de la primera fraccion");
            decimal num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el denominador de la primera fraccion");
            decimal den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numerador de la segunda fraccion");
            decimal num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el denominador de la segunda fraccion");
            decimal den2 = int.Parse(Console.ReadLine());


            if (opcion == 1)
            {
                decimal frac1 = num1 / den1;
                decimal frac2 = den2 / den2;
                decimal resultado = frac1 + frac2;
                Console.WriteLine("El resultado es " + resultado.ToString("0.00"));
            }
            else if (opcion == 2)
            {
                decimal frac1 = num1 / den1;
                decimal frac2 = den2 / den2;
                decimal resultado = frac1 - frac2;
                Console.WriteLine("El resultado es " + resultado.ToString("0.00"));
            }
            else if (opcion == 3)
            {
                decimal frac1 = num1 / den1;
                decimal frac2 = den2 / den2;
                decimal resultado = frac1 * frac2;
                Console.WriteLine("El resultado es " + resultado.ToString("0.00"));
            }
            else if (opcion == 4)
            {
                decimal frac1 = num1 / den1;
                decimal frac2 = den2 / den2;
                decimal resultado = frac1 / frac2;
                Console.WriteLine("El resultado es " + resultado.ToString("0.00"));
            }
            else { 
                Console.WriteLine("Ingrese un opcion valida");
            }
            Console.ReadLine();
        }
    }
}
