﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el  factorial de un numero");
            Console.WriteLine("Coloque un numero");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i<= numero; i++) {
                resultado *= i;
            }
            Console.WriteLine("El resultado es " + resultado);
            Console.ReadLine();


        }
    }
}
