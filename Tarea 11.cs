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
            int n1,n2;
            
            Console.WriteLine("Ingrese primer numero entero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero entero");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("El primer numero ingresado es mayor que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo numero ingresado es mayor que el primero");
            }
            Console.ReadKey();
        }
    }
}
