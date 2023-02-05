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
            Console.WriteLine("El promedio es de " + promedio);
            Console.ReadLine();
        }
    }
}
