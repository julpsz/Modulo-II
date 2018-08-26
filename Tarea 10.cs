using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.WriteLine("Ingrese un numero entero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
            }
            Console.ReadKey();
        }
    }
}
