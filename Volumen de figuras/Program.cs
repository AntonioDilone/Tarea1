using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen_de_figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula volumen");
            Console.WriteLine("0- Cubo  1- Esfera  2- Cono  3- Piramide");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Ingrese el area del cubo");
                double area = double.Parse(Console.ReadLine());
                double volumen = Math.Pow(area,3);
                Console.WriteLine("El volumen del cubo es de " + volumen);
            }

            else if (opcion == 1)
            {
                Console.WriteLine("Ingrese el radio de la esfera");
                double radio = double.Parse(Console.ReadLine());
                radio = Math.Pow(radio, 3);
                double volumen = (4 * 3.14 * radio) / 3;
                Console.WriteLine("El volumen de la esfera es de " + volumen);
            }

            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese el radio del cono");
                double radio = double.Parse(Console.ReadLine());
                radio = Math.Pow(radio, 2);
                Console.WriteLine("Ingrese la altura del cono");
                double altura = double.Parse(Console.ReadLine());
                double volumen = (3.14 * radio * altura) / 3;
                Console.WriteLine("El volumen del cono es de " + volumen);
            }

            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese el area de la base");
                double arba = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del cono");
                double altura = double.Parse(Console.ReadLine());
                double volumen = (arba * altura) / 3;
                Console.WriteLine("El volumen de la piramide es de " + volumen);
            }

            else
            {
                Console.WriteLine("Ingrese una opcion valida");
            }
            Console.ReadLine();
        }
    }
}
