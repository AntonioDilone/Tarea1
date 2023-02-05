using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_general
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que resuelve ecuaciones de segundo grado por formula general");
            Console.WriteLine("Ingrese el valor de la variable cuadrada");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la variable");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del constante");
            int c = int.Parse(Console.ReadLine());


            double b2 = Math.Pow(b, 2);
            double raiz = Math.Sqrt((b2-(4*a*c)));

            double num = -b + raiz;
            double num2 = -b - raiz;

            double deno = 2 * a;
            double resultado = num / deno;
            double resultado2 = num2 / deno;
            Console.WriteLine("El resultado si hacemos la suma es " + resultado);
            Console.WriteLine("El resultado si hacemos la resta es " + resultado2);
            Console.ReadLine();

        }
    }
}
