using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertir temperaturas");
            Console.WriteLine("1-Celcius a kelvin 2-Celcius a fahrenheit 3-Kelvin a Celcius 4- Kelvin a fahrenheit 5- Fahrenheit a Celcius 6-Fahrenheit a kelvin");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese los grados C");
                double rest = double.Parse(Console.ReadLine());
                rest += 273.15;
                Console.WriteLine(rest + "K");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese los grados C");
                double rest = double.Parse(Console.ReadLine());
                double form = (9 * rest) / 5;
                form += 32;
                Console.WriteLine(form + "F");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese los grados K");
                double rest = double.Parse(Console.ReadLine());
                rest -= 273.15;
                Console.WriteLine(rest + "C");
            }
            else if (opcion == 4) {
                Console.WriteLine("Ingrese los grados K");
                double rest = double.Parse(Console.ReadLine());
                double form = (rest - 273.15) * 9 / 5;
                form += 32;
                Console.WriteLine(form + "F");

            } else if (opcion == 5)
            {
                Console.WriteLine("Ingrese los grados F");
                double rest = double.Parse(Console.ReadLine());
                double form = (rest - 32) * 5 / 9;
                Console.WriteLine(form + "C");
            } else if (opcion == 6) {
                Console.WriteLine("Ingrese los grados F");
                double rest = double.Parse(Console.ReadLine());
                double form = (rest - 32) * 5 / 9;
                form += 273.15;
                Console.WriteLine(form + "K");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
            Console.ReadLine();
            
        }
    }
}
