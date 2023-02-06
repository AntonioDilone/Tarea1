using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular calificacion promedio");
            Console.WriteLine("Cuantas calificaciones quiere añadir?");
            int cant = int.Parse(Console.ReadLine());
            int promedio = 0;
            string literal = "";

            List<int> calificaciones = new List<int>();

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Añada una nota");
                calificaciones.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Nota añadida con exito");
            }

            foreach (var item in calificaciones)
            {
                promedio += item;
            }
            promedio = promedio / calificaciones.Count;

            if (promedio >= 90)
            {
                literal += "A";
            }
            else if (promedio >= 80)
            {
                literal += "B";
            } 
            else if (promedio >= 70) {
                literal += "C";
            }
            else if (promedio >= 60)
            {
                literal += "D";
            }
            else {
                Console.WriteLine("F");
            }


            Console.WriteLine("El promedio es de " + promedio + " y seria una " + literal);
            Console.ReadLine();
        }
    }
}
