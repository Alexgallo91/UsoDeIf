using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingresa el primer numero:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Ambos numeros son iguales");
            }

            if (n1 != n2)
            {
                Console.WriteLine("Ambos numeros son diferentes");
            }

            if (n1 < n2)
            {
                Console.WriteLine("{0} es menor a {1}", n1, n2);
            }

            if (n1 > n2)
            {
                Console.WriteLine("{0} es mayor a {1}", n1, n2);
            }

            if (n1 > n2 || n1 < n2)
            {
                Console.WriteLine("se cumplio al menos una condicioon");
            }

            if (n1 == n1 && n2 == n2)
            {
                Console.WriteLine("Se cumplen ambas condiciones");
            }

            Console.ReadKey();
        }
    }
}
