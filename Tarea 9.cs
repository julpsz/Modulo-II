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
            int n1;
            int n2;
            Console.WriteLine("Ingrese primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El producto entre n1 y n2 es: {0}", n1*n2);
            Console.ReadKey();
        }
    }
}
