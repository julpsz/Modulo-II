﻿using System;
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
            char n1;
                        
            Console.WriteLine("Ingrese un numero del 1 al 5");
            n1 = Convert.ToChar(Console.ReadLine());
            switch(n1)
            {
                case '1':
                    Console.WriteLine("UNO");
                    break;
                case '2':
                    Console.WriteLine("DOS");
                    break;
                case '3':
                    Console.WriteLine("TRES");
                    break;
                case '4':
                    Console.WriteLine("CUATRO");
                    break;
                case '5':
                    Console.WriteLine("CINCO");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
