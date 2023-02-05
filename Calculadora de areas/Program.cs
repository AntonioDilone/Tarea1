using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula areas en cm^2");
            Console.WriteLine("0- Cuadrado  1- Circulo  2- Triangulo  3- Pentagono  4- Hexagono");
            int opcion = int.Parse(Console.ReadLine());
            double area;

            if (opcion == 0) {
                Console.WriteLine("Ingrese la medida de un lado");
                int lado = int.Parse(Console.ReadLine());
                area = lado * lado;
                Console.WriteLine("El area es de " + area + "cm^2");
            } 
            
            else if (opcion == 1)
            {
                Console.WriteLine("Ingrese el radio de su circulo");
                int radio = int.Parse(Console.ReadLine());
                area = 3.14 * (radio * radio);
                Console.WriteLine("El area es de " + area + "cm^2");
            } 
            
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese la base");
                int bas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura");
                int altura = int.Parse(Console.ReadLine());
                area = (bas * altura) / 2;
                Console.WriteLine("El area es de " + area + "cm^2");
            } 
            
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese la medida de un lado");
                int lado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la medida del apotema");
                int apotema = int.Parse(Console.ReadLine());
                double per = lado * 5;
                area = (per * apotema) /2;

                Console.WriteLine("El area es de " + area + "cm^2");
            } 
            
            else if (opcion == 4)
            {
                Console.WriteLine("Ingrese la medida de un lado");
                int lado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la medida del apotema");
                int apotema = int.Parse(Console.ReadLine());
                double per = lado * 5;
                area = (per * apotema) / 2;

                Console.WriteLine("El area es de " + area + "cm^2");
            } 
            
            else {
                Console.WriteLine("Ingrese una opcion valida");
            }
            Console.ReadLine();
        }
    }
}
