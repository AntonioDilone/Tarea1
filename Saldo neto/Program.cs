using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo_neto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcule el salario neto, basado en el salario bruto ");
            Console.WriteLine("Ingrese la cantidad de pago por hora");
            double dinero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas al mes");
            int horas = int.Parse(Console.ReadLine());

            if (horas > 44)
            {
                double extra = dinero * 0.30;
                double salar = horas * dinero;
                double neto = salar * 0.591; /*5.91*/
                salar += extra;
                neto = salar - neto;
                Console.WriteLine("El salario bruto es de " + salar + "pesos. El salario neto es de " + neto);
            }
            else {
                double salar = horas * dinero;
                double neto = salar * 0.591; /*5.91*/
                neto = salar - neto;
                Console.WriteLine("El salario bruto es de " + salar + "pesos. El salario neto es de " + neto);
            }
            Console.ReadLine();
        }
    }
}
