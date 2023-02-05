using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula fibonacci");
            Console.WriteLine("Coloque un numero");
            int n1 = 0;
            int n2 = 1;
            int numero = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numero; i++) {
                int n3 = n1 + n2;
                Console.WriteLine(n3+" ");
                n1= n2;
                n2= n3;
            };
            Console.ReadLine();
        }
    }
}
