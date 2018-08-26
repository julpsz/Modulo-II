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
            float n1,n2;
            float resultado;
            
            Console.WriteLine("Ingrese primer numero entero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero entero");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 / n2;
            if (n2 != 0)
            {
                Console.WriteLine("La division numero1 / numero2 es {0}", resultado);
            }
            else
            {
                Console.WriteLine("Error. No se puede dividir por cero");
            }
            Console.ReadKey();
        }
    }
}
